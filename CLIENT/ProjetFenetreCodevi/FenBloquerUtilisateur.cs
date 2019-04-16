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
    
    public partial class FenBloquerUtilisateur : Form
    {
        public TcpChannel tcp = null;
        public InterfaceUtilisateur Ut = null;
        public FenBloquerUtilisateur()
        {
            tcp = new TcpChannel();
            //ChannelServices.RegisterChannel(tcp);

            Ut = (InterfaceUtilisateur)Activator.GetObject(typeof(InterfaceUtilisateur), "tcp://localhost:6060/objetutilisateur");
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FenBloquerUtilisateur_Load(object sender, EventArgs e)
        {
            this.Size = new Size(403, 187);
            txtcodecompte.Focus();
        }
      
        string code = null;
        Boolean action;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtcodecompte.Text.Equals(""))
                {
                    MessageBox.Show("Entrer le code de l'utilisateur", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                   

                    code = txtcodecompte.Text;
                   bool util = Ut.RechercherUtilisateur(code);
                    if (util == false)
                    {
                        MessageBox.Show("Utilisateur inexistant", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        //MessageBox.Show(ut.Get_etatcompte());
                        if ((Ut.RecupererEtat()) == "desactiver")
                        {
                            MessageBox.Show("Cet Utilisateur est déjà inactif", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            this.Size = new Size(403, 247);
                        }
                    }

                }
            }
            catch (Exception po) { MessageBox.Show(po.Message); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //string activer = "desactiver";
                bool u = Ut.RechercherUtilisateur(code);
                if (Ut.RecupererEtat() == "activer"||Ut.RecupererEtat() == "Activer")
                {
                    string etatcompte = "desactiver";
                    action = Ut.BlocUtilisateur(code, etatcompte);

                    if (action == true)
                    {
                        MessageBox.Show("Vous avez bloqué l'utilisateur " + code, "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtcodecompte.Clear();
                        this.Size = new Size(403, 187);

                    }
                    else
                    {
                        MessageBox.Show("Utilisateur non desactivé", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }


            }

            catch (Exception nb) { MessageBox.Show(nb.Message); }
        }

        private void txtcodecompte_Click(object sender, EventArgs e)
        {

            this.Size = new Size(403, 187);
        }
    }
}
