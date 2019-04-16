
using Com.ProjetCodevi.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetFenetreCodevi
{
    public partial class Fenblocquer : Form
    {
        public TcpChannel tcp = null;
        public InterfaceCompte Ut = null;
        public Fenblocquer()
        {
            tcp = new TcpChannel();
            //ChannelServices.RegisterChannel(tcp);

            Ut = (InterfaceCompte)Activator.GetObject(typeof(InterfaceCompte), "tcp://localhost:6060/objetcompte");
            InitializeComponent();
        }

        private void Fenblocquer_Load(object sender, EventArgs e)
        {
            this.Size = new Size(423, 182);
            txtcodecompte.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int validite = 0;
            string bloquage = "";
            if (txtcodecompte.Text.Equals(""))
            {

                validite = 1;

                MessageBox.Show("Remplissez le champ de recherche", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {

                    bool cl = Ut.RechercherCompte(txtcodecompte.Text);
                    bloquage = Ut.RecupererEtat();

                    if (!cl.Equals(false))
                    {

                        if (bloquage.Equals("desactiver"))
                        {
                            MessageBox.Show("Ce compte est deja inactif", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                        else {
                            this.Size = new Size(414, 244);
                        }
                        

                    }

                }
                catch (Exception)
                {


                    MessageBox.Show("Compte n'existe pas", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            
           
            string test = null;
            
           test= Ut.DesactiverCompte(txtcodecompte.Text);
           if (test == null)
           {
               MessageBox.Show("Desactivation non reussie", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

           }
           else {
               MessageBox.Show("Blocage du compte reussi", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
               txtcodecompte.Clear();
               this.Size = new Size(423, 182);
               txtcodecompte.Focus();
           }
        }

        private void txtcodecompte_TextChanged(object sender, EventArgs e)
        {
            this.Size = new Size(423, 182);
        }

        private void txtcodecompte_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void txtcodecompte_MouseClick_1(object sender, MouseEventArgs e)
        {
            txtcodecompte.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
