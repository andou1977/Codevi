////using Com.ProjetCodevi.Controleur;
////using Com.ProjetCodevi.Domaine;
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
    public partial class enregistrercompte : Form
        
    {
        public Random r;
        public static InterfaceCompte objetcompte = null;
        public static InterfaceClient objetclient = null;
        public static InterfaceUtilisateur Ut = null;


        public static TcpChannel tcp = null;
        public enregistrercompte()
        {




            InitializeComponent();
        }
        public static string codecompte;
        public static string numco;
        public static int numeroco;
        private void enregistrercompte_Load(object sender, EventArgs e)
        {

            Random t = new Random();
             numeroco = t.Next(1, 9890);
             numco = string.Concat("CPT-", numeroco);
             codecompte = numco;
             txtcode.Text = codecompte;
            ////////////////
            this.Size = new Size(447,391);

            cmbdevise.SelectedIndex = 0;
            //label5.Visible = false;
            label7.Visible = false;
            //label7.Visible = false;
            label8.Visible = false;
            txtcodeclient.Focus();
            txtcodeclient.Select();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string codeclient = txtcodeclient.Text;
            int verification = 0;
            if (txtcodeclient.Text != "")
            {

              
                if (objetclient.Rechercherclient(codeclient) == null)
                {


                    MessageBox.Show("Le client n'existe pas", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    verification = 1;

                }

            }
            else if (txtcodeclient.Text.Equals("") || txtmontant.Text == "")
            {
                MessageBox.Show("Le champ client et le champ montant sont vides", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                verification = 1;
            }


            try
            {

                if (float.Parse(txtmontant.Text) <= 0)
                {

                    MessageBox.Show("La valeur du montant ne doit pas etre inferieur a zero", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    verification = 1;
                }

            }
            catch
            {
                if (verification.Equals(0))
                {
                    MessageBox.Show("Le champ montant doit avoir une valeur Numerique", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    verification = 1;
                }
            }


            if (verification != 1)
            {

                if (cmbdevise.SelectedItem.Equals("Gourdes") && (float.Parse(txtmontant.Text) < 100))
                {
                    MessageBox.Show("Le montant mininmal doit etre 100 Gourdes", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else

                    if (cmbdevise.SelectedItem.Equals("Dollards") && (float.Parse(txtmontant.Text) < 5))
                    {
                        MessageBox.Show("Le montant mininmal doit etre 5 Dollards", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                {
                    string devise = cmbdevise.Text;
                    float montant = float.Parse(txtmontant.Text);

                    



                    this.Size = new Size(447, 391);

                    DialogResult choix = MessageBox.Show("Voici les valeurs qui vont etre enregistrées\n----------------------------------------------------\ncode du compte:  " + numco + "\nCode du Client: " + codeclient + "\nDevise: " + devise + "\nMontant: " + montant, "Confirmation", MessageBoxButtons.YesNoCancel);
                    if (choix.Equals(DialogResult.Yes))
                    {
                       
                        string test = null;
                        test = objetcompte.CreerNouveaucompte(codecompte, codeclient, devise, montant);
                        if (test != null)
                        {
                            MessageBox.Show("Compte créé avec succès!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            String de = System.DateTime.Now.ToShortDateString();

                            //convertir date actuelle en tableau
                            string[] tde = de.Split('/');
                            //pret.EnregistrerTransaction(numco, "Creation compte", float.Parse(txtmontant.Text), DateTime.Parse(de), fenConnection.nomutilisateur);
                            Ut.RetracerOperation(fenConnection.nomutilisateur, "Creation compte",fenConnection.adressemac());
                            txtcodeclient.Clear();
                            txtmontant.Clear();
                            Random t = new Random();
                            numeroco = t.Next(1, 9890);
                            numco = string.Concat("CPT-", numeroco);
                            codecompte = numco;
                            txtcode.Text = codecompte;
                        }
                        else
                        {
                            MessageBox.Show("Echec de creation du compte", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    else if (choix.Equals(DialogResult.No)) {
                        txtcodeclient.Clear();
                        txtmontant.Clear();
                        cmbdevise.ResetText();
                        txtcodeclient.Select();
                    }
                }



            }
        }

        private void cmbdevise_Click(object sender, EventArgs e)
        {
            if (txtcodeclient.Text != "")
            {
                string codeclient = txtcodeclient.Text;

                if (objetclient.Rechercherclient(codeclient) == null)
                {

                    //label5.Visible = true;
                    label7.Visible = true;
                    label7.Text = "Client inexistant";
                    label7.ForeColor = Color.Red;
                }
                else
                {

                    //label5.Visible = false;
                    label7.Visible = false;
                }
            }
            else
            {
                //label5.Visible = false;
                label7.Visible = true;
                label7.Text = "Remplis ce Champ";

                label7.ForeColor = Color.Red;
            }
        }



        private void txtcodeclient_TextChanged(object sender, EventArgs e)
        {
            //label5.Visible = false;
            label7.Visible = false;
        }

        private void txtmontant_Click(object sender, EventArgs e)
        {
            if (txtcodeclient.Text != "")
            {
                string codeclient = txtcodeclient.Text;
                
                if (objetclient.Rechercherclient(codeclient) == null)
                {

                    //label5.Visible = true;
                    label7.Visible = true;
                    label7.Text = "Client inexistant";
                    label7.ForeColor = Color.Red;
                    label8.Visible = false;
                }
                else
                {

                    //label5.Visible = false;
                    label7.Visible = false;
                }
            }
            else
            {
                //label5.Visible = false;
                label7.Visible = true;
                label7.Text = "Remplissez ce Champ";
                label8.Visible = false;

                label7.ForeColor = Color.Red;
            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {

            try
            {
                if (txtmontant.Text == "")
                {

                    //label7.Visible = false;
                    label8.Visible = true;
                    label8.Text = "Remplissez ce Champ";

                    label8.ForeColor = Color.Red;

                }
                else if (float.Parse(txtmontant.Text) <= 0)
                {

                    label8.Visible = true;
                    label8.Text = "Valeur ne doit pas etre inferieur a Zero";
                }
                else
                {
                   
                    //label7.Visible = false;
                    label8.Visible = false;
                }
            }
            catch
            {
                //label7.Visible = true;
                label8.Visible = true;
                label8.Text = "Valeur Numerique";

               
            }
        }
        private void txtmontant_DoubleClick(object sender, EventArgs e)
        {
            label7.Visible = false;
        }

        private void txtmontant_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtmontant_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

