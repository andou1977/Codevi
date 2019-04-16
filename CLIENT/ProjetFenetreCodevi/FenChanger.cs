//using Com.ProjetCodevi.Controleur;
//using Com.ProjetCodevi.Domaine;
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
    public partial class FenChanger : Form
    {
        public Random r;
        public static Com.ProjetCodevi.Interface.InterfaceUtilisateur objetutilisateur = null;
        public static TcpChannel tcp = null;
        public FenChanger()
        {
            tcp = new TcpChannel();
            //ChannelServices.RegisterChannel(tcp);

            objetutilisateur = (InterfaceUtilisateur)Activator.GetObject(typeof(InterfaceUtilisateur), "tcp://localhost:6060/objetutilisateur");
            InitializeComponent();
        }
        public static int fois = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtactuel.Text.Equals(""))
            {
                MessageBox.Show("Entrer le mot de passe actuel!");

            }
            else
            {



                if (txtactuel.Text.Equals(fenConnection.password))
                {
                    txtpseudo.Enabled = true;
                    btenregistrer.Enabled = true;
                    txtpseudo.Focus();
                   

                    txtconfirmer.Enabled = true;
                    txtmotdepasse.Enabled = true;
                   

                    txtpseudo.Text = fenConnection.pseudouser;
                    //txtmotdepasse.Text = fenConnection.password;
                }
                else
                {

                    MessageBox.Show(" Mot de passe incorrect,\n Réessayer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    fois++;
                }
                if (fois == 3)
                {
                    MessageBox.Show("  Vous n'êtes pas " + fenConnection.nomutilisateur.ToUpper() + "\n  Deconnection immediate forcée!", "Deconnexion forcée", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                    Application.Restart();
                }
            }
        }

        private void FenChanger_Load(object sender, EventArgs e)
        {
            
            txtmotdepasse.Enabled = false;
            txtconfirmer.Enabled = false;
            txtpseudo.Enabled = false;
            btenregistrer.Enabled = false;
        }

        private void txtmotdepasse_TextChanged(object sender, EventArgs e)
        {
            lbconfirmer.Visible = true;
            txtconfirmer.Visible = true;
        }

        private void txtmotdepasse_Click(object sender, EventArgs e)
        {
            lbconfirmer.Visible = true;
            txtconfirmer.Visible = true;
        }

        private void btannuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btenregistrer_Click(object sender, EventArgs e)
        {

            if (txtpseudo.Text.Equals("") || txtmotdepasse.Text.Equals(""))
            {
                MessageBox.Show("Remplissez tous les champs", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                bool uti=objetutilisateur.RechercherPseudoModpas(txtpseudo.Text, txtmotdepasse.Text);

                if (uti!= null)
                {
                  
                    if (objetutilisateur.RecupererPseudo().Equals(txtpseudo.Text))
                    {
                        MessageBox.Show("Ce pseudo est déjà utilisé, essayer un autre!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }

                  
                }
                else
                {

                    if (txtmotdepasse.Text != txtconfirmer.Text)
                    {
                        if (txtconfirmer.Text.Equals(""))
                        {
                            MessageBox.Show("Veuillez confirmer le mot de passe", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("Les mots de passe sont differents", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        if (txtpseudo.Text.Equals(fenConnection.pseudouser) && txtmotdepasse.Text.Equals(fenConnection.password))
                        {
                            MessageBox.Show("Aucune modification n'a été apportée", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            int test = 0;
                            //Utilisateur et = new Utilisateur(fenConnection.codeuser, fenConnection.nomutilisateur, fenConnection.prenomutilisateur, txtpseudo.Text, txtmotdepasse.Text, fenConnection.droitdacces, fenConnection.etat);
                           
                            test = objetutilisateur.ModifierUtilisateur(fenConnection.codeuser, fenConnection.nomutilisateur, fenConnection.prenomutilisateur, txtpseudo.Text, txtmotdepasse.Text, fenConnection.droitdacces, fenConnection.etat);

                            string opera = "Modifier Utilisateur";
                            objetutilisateur.RetracerOperation(fenConnection.nomutilisateur, opera,fenConnection.adressemac());
                            if (test == 0)
                            {

                                MessageBox.Show("Changement de compte non réussi!", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                MessageBox.Show("Changement de compte réussi!", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                fenConnection.pseudouser = txtpseudo.Text;
                                fenConnection.password = txtmotdepasse.Text;
                                txtactuel.Clear();
                                txtmotdepasse.Enabled = false;
                                txtconfirmer.Enabled = false;
                                txtpseudo.Enabled = false;
                                txtpseudo.Clear();
                                txtmotdepasse.Clear();
                                txtconfirmer.Clear();

                            }
                        }
                    }
                }
            }
        }

        private void txtactuel_TextChanged(object sender, EventArgs e)
        {
            txtmotdepasse.Enabled = false;
            txtconfirmer.Enabled = false;
            txtpseudo.Enabled = false;
            txtpseudo.Clear();
            txtmotdepasse.Clear();
            txtconfirmer.Clear();
        }
        }
    }

