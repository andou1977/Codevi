using Com.ProjetCodevi.Interface;
using MySql.Data.MySqlClient;
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
    public partial class rechercherutilisateur : Form
    {
        public TcpChannel tcp = null;
        public InterfaceClient objetclient = null;
        public InterfaceCompte objetcompte = null;
        public InterfaceUtilisateur objetutilisateur = null;
        public InterfacePret objetpret = null;
        public rechercherutilisateur()
        {
            tcp = new TcpChannel();
            objetclient = (InterfaceClient)Activator.GetObject(typeof(InterfaceClient), "tcp://localhost:6060/objetclient");
            objetcompte = (InterfaceCompte)Activator.GetObject(typeof(InterfaceCompte), "tcp://localhost:6060/objetcompte");
            objetpret = (InterfacePret)Activator.GetObject(typeof(InterfacePret), "tcp://localhost:6060/objetpret");
            objetutilisateur = (InterfaceUtilisateur)Activator.GetObject(typeof(InterfaceUtilisateur), "tcp://localhost:6060/objetutilisateur");
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            try
            {
                if (txtcode.Text.Equals(string.Empty))
                {
                    MessageBox.Show("Entrer le code de l'utilisateur", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                   
                  bool  result=objetutilisateur.RechercherUtilisateur(txtcode.Text);

                    if (result != false)
                    {
                        this.Size = new Size(422, 444);


                        txtnom.Text = objetutilisateur.RecupererNom();
                        txtprenom.Text = objetutilisateur.RecupererPrenom();
                        txtpseudo.Text = objetutilisateur.RecupererPseudo();

                        txtacces.Text = objetutilisateur.RecupererDroitdacces();
                        txtetat.Text = objetutilisateur.RecupererEtat();
                        objetutilisateur.RecupererDate();
                    }
                    else
                    {
                        MessageBox.Show("Cet Utilisateur n'existe pas", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);                

                          
                   
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void rechercherutilisateur_Load(object sender, EventArgs e)
        {

            button1.Focus();
            // pan1.Visible = false;
            Size = new Size(422, 192);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtcode_TextChanged(object sender, EventArgs e)
        {
            this.Size = new Size(422, 192);
        }
    }
}
