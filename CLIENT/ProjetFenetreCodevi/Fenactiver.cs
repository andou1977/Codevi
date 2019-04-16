
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Com.ProjetCodevi.Interface;
using System.Runtime.Remoting.Channels.Tcp;
namespace ProjetFenetreCodevi
{
    public partial class Fenactiver : Form
    {
        public TcpChannel tcp = null;
        public InterfaceCompte comp = null;
        public Fenactiver()
        {
            tcp = new TcpChannel();
            //ChannelServices.RegisterChannel(tcp);

            comp = (InterfaceCompte)Activator.GetObject(typeof(InterfaceCompte), "tcp://localhost:6060/objetenfant");
       
            InitializeComponent();
        }

        private void txtcodecompte_TextChanged(object sender, EventArgs e)
        {
            this.Size = new Size(423, 182);
        }

        private void Fenactiver_Load(object sender, EventArgs e)
        {
            this.Size = new Size(423, 182);
            txtcodecompte.Focus();
            txtcodecompte.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int validite = 0;
            string bloquage = "";
            if (txtcodecompte.Text.Equals(""))
            {

                validite = 1;
                txtcodecompte.Text = "Remplissez le champ";
                MessageBox.Show("Remplissez le champ de recherche", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {

                   
                   bool cl = comp.RechercherCompte(txtcodecompte.Text);
                    bloquage = comp.RecupererEtat();

                    if (!cl.Equals(null))
                    {

                        if (bloquage.Equals("activer"))
                        {
                            MessageBox.Show("Ce compte est deja actif", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {

                            this.Size = new Size(414, 243);
                           
                        }

                    }

                }
                catch (Exception)
                {


                    MessageBox.Show("Ce compte n'existe pas", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            string suc = null;
            
           suc= comp.ActiverCompte(txtcodecompte.Text);
           if (suc == null)
           {

               MessageBox.Show("Activaction  non reussie", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           }
           else {
               MessageBox.Show("Activaction  reussie", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
               txtcodecompte.Clear();
               this.Size = new Size(423, 182);
               txtcodecompte.Focus();
               txtcodecompte.Select();
           }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
