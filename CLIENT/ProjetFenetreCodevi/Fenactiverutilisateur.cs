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
    public partial class Fenactiverutilisateur : Form
    {
        public TcpChannel tcp = null;
        public InterfaceUtilisateur Ut = null;

        public Fenactiverutilisateur()
        {
            tcp = new TcpChannel();
            //ChannelServices.RegisterChannel(tcp);

            Ut = (InterfaceUtilisateur)Activator.GetObject(typeof(InterfaceUtilisateur), "tcp://localhost:6060/objetutilisateur");
            InitializeComponent();
        }

        private void Fenactiverutilisateur_Load(object sender, EventArgs e)
        {
            this.Size = new Size(403, 187);
            txtcodecompte.Focus();

        }
               
        string code=null;
        Boolean action;
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtcodecompte.Text.Equals(""))
            {
                MessageBox.Show("Entrer le code de l'utilisateur", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                code=txtcodecompte.Text;
                
                 bool uti= Ut.RechercherUtilisateur(code);
                if (uti == false)
                {
                    MessageBox.Show("Utilisateur inexistant", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else {
                    //MessageBox.Show(ut.Get_etatcompte());
                    if ((Ut.RecupererEtat()) == "activer")
                    {
                        MessageBox.Show("Cet Utilisateur est déjà actif", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        this.Size = new Size(403, 247);
                    }
                }

            }
        }

        private void txtcodecompte_Click(object sender, EventArgs e)
        {
            this.Size = new Size(403, 187);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //string activer = "desactiver";
                bool ut=(Ut.RechercherUtilisateur(code));
                if (Ut.RecupererEtat() == "desactiver")
                {
                    string etatcompte = "activer";
                    action = Ut.BlocUtilisateur(code, etatcompte);

                    if (action == true)
                    {
                        MessageBox.Show("Vous avez débloqué l'utilisateur " + code, "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtcodecompte.Clear();
                        this.Size = new Size(403, 187);
                           
                    }
                    else
                    {
                     

                    }

                }
               

            }
            
            catch (Exception nb) { MessageBox.Show(nb.Message); }
        }

        private void txtcodecompte_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
