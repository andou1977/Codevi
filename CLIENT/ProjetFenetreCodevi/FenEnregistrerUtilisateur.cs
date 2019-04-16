using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using Com.ProjetCodevi.Interface;
using System.Runtime.Remoting.Channels.Tcp;

namespace ProjetFenetreCodevi
{
    public partial class FenEnregistrerUtilisateur : Form
    {
        public static InterfaceCompte objetcompte = null;
        public static InterfaceClient objetClient = null;
        public static InterfaceUtilisateur objetUtilisateur = null;
        public static TcpChannel tcp = null;
        public FenEnregistrerUtilisateur()
        {
            tcp = new TcpChannel();
            objetcompte = (InterfaceCompte)Activator.GetObject(typeof(InterfaceCompte), "tcp://localhost:6060/objetcompte");
            objetClient = (InterfaceClient)Activator.GetObject(typeof(InterfaceClient), "tcp://localhost:6060/objetclient");
            objetUtilisateur = (InterfaceUtilisateur)Activator.GetObject(typeof(InterfaceUtilisateur), "tcp://localhost:6060/objetutilisateur");
            InitializeComponent();
        }


        private void btannuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btenregistrer_Click(object sender, EventArgs e)
        {
            if (txtnom.Text.Equals("") || txtprenom.Text.Equals("") || txtpseudo.Text.Equals("") || txtmotdepasse.Text.Equals("") || txtconfirmer.Text.Equals(""))
            {
                MessageBox.Show("Tous les champs doivent etre remplis!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtmotdepasse.Text != txtconfirmer.Text)
                {
                    MessageBox.Show("Les mots de passe ne correspondent pas!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtmotdepasse.Clear();
                    txtconfirmer.Clear();
                    txtmotdepasse.Select();

                }
                else
                {
                  
                   bool uti= objetUtilisateur.RechercherPseudo(txtpseudo.Text, txtmotdepasse.Text);

                    if (uti != false)
                    {
                        if (objetUtilisateur.RecupererPseudo().Equals(txtpseudo.Text))
                        {
                            MessageBox.Show("Ce pseudo est déjà utilisé, essayez un autre!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                       
                    }
                    else
                    {

                        string etat = String.Format("activer");
                        Random r = new Random();

                        string Date = System.DateTime.Now.ToShortDateString();
                        string code = String.Format("ut-{0}", r.Next(0, 1000));                        
                        DialogResult choix = MessageBox.Show("Informations entrées\n-----------------------------------\nCode:" + code + "\nNom: " + txtnom.Text + "\nPrenom: " + txtprenom.Text + "\nPseudo: " + txtpseudo.Text + "\nDroit d'acces: " + cmbdroit.SelectedItem + "\nEtat Compte: " + etat + "\nDate: " + Date, "Voulez-vous entregistrer?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (choix == DialogResult.Yes)
                        {

                            objetUtilisateur.modifierCode(code);
                            objetUtilisateur.modifierNom(txtnom.Text);
                            objetUtilisateur.modifierPrenom(txtprenom.Text);
                            objetUtilisateur.modifierPseudo(txtpseudo.Text);
                            objetUtilisateur.modifierMotdepasse(txtmotdepasse.Text);
                            objetUtilisateur.modifierDroitdacces(cmbdroit.SelectedItem.ToString());
                            objetUtilisateur.modifierEtat(etat);
                            objetUtilisateur.modifierDate(Date);

                            //MemoryStream ms = new MemoryStream();
                            //picimage.Image.Save(ms, picimage.Image.RawFormat);
                            //byte[] img = ms.ToArray();              

                            //util.Set_photo(img);

                            int test = 0;
                            test = objetUtilisateur.AjouterUtilisateur(objetUtilisateur);
                            if (test != 0)
                            {
                                MessageBox.Show("Utilisateur Enregistré! Code: " + code, "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtnom.Clear();
                                txtprenom.Clear();
                                cmbdroit.SelectedIndex = 0;
                                txtpseudo.Clear();
                                txtmotdepasse.Clear();
                                txtconfirmer.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Utilisateur non enregistré!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            txtnom.Clear();
                            txtprenom.Clear();
                            cmbdroit.SelectedIndex = 0;
                            txtpseudo.Clear();
                            txtmotdepasse.Clear();
                            txtconfirmer.Clear();
                        }

                    }
                }


            }
        }

        private void FenEnregistrerUtilisateur_Load(object sender, EventArgs e)
        {
            cmbdroit.SelectedIndex = 0;
        }
    }
}

//        private void btnchoisir_Click(object sender, EventArgs e)
//        {
//             OpenFileDialog of = new OpenFileDialog();
//            of.Filter = "choose image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif";

//            if (of.ShowDialog() == (DialogResult.OK))
//            {
//                picimage.Image = Image.FromFile(of.FileName);
//            }
//        }
       
//    }
//}
