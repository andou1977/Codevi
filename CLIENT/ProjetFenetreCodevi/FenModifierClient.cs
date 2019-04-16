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
    public partial class FenModifierClient : Form
    {
        public TcpChannel tcp = null;
        public InterfaceClient  Ut = null;
        public FenModifierClient()
        {

            tcp = new TcpChannel();
                       Ut = (InterfaceClient)Activator.GetObject(typeof(InterfaceClient), "tcp://localhost:6060/objetclient");
            InitializeComponent();
        }
        public static string nom;
        public static string prenom;
        public static string sexe;
        public static string telephone;
        public static string adresse;
        public static string identite;
        public static string email;

        private void FenModifierClient_Load(object sender, EventArgs e)
        {
            btnmodifier.Enabled = true;
            txtid.Focus();
            txtid.Select();
          
           
            groupBox1.Visible = false;
            this.Size = new Size(399, 228);
            txtid.Focus();
        }

       

        private void btrechercher_Click(object sender, EventArgs e)
        {
            if (txtid.Text.Equals(""))
            {
                txtid.ForeColor = Color.Red;
                txtid.Text = "Entrer le code du client";
            }
            else
            {
                try
                {

                    //Client cl = null;
                    bool cl = Ut.Rechercherclient(txtid.Text);
                    if (!cl.Equals(false))
                    {
                        this.Size = new Size(399, 538);
                        txtnom.Enabled = false;
                        txtprenom.Enabled = false;
                        cmbsexe.Enabled = false;
                        rtbadresse.Enabled = false;
                        msktelephone.Enabled = false;
                        mskidentite.Enabled = false;
                        txtnom.Text = Ut.RecupererNom();
                        nom = Ut.RecupererNom();
                        txtprenom.Text = Ut.RecupererPrenom();
                        prenom = Ut.RecupererPrenom();

                        cmbsexe.Text = Ut.RecupererSexe();
                        sexe = Ut.RecupererSexe();
                        rtbadresse.Text = Ut.RecupererAdresses();
                        adresse = Ut.RecupererAdresses();
                        msktelephone.Text = Ut.RecupererTelephone();
                        telephone = Ut.RecupererTelephone();
                        mskidentite.Text = Ut.RecupererCin();
                        identite = Ut.RecupererCin();
                        email = Ut.RecupererEmail();
                        btnmodifier.Enabled = true;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Client inexistant", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
        }

        private void txtid_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txtid.ForeColor = Color.Black;

            txtnom.Clear();
            txtprenom.Clear();
            cmbsexe.ResetText();
            rtbadresse.Clear();
            mskidentite.Clear();
            //txttelephone.Clear();
            this.Size = new Size(399, 228);
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {
            txtid.ForeColor = Color.Black;

            txtnom.Clear();
            txtprenom.Clear();
            cmbsexe.ResetText();
            rtbadresse.Clear();
            mskidentite.Clear();
            //txttelephone.Clear();
            this.Size = new Size(399, 228);
        }

        private void btannuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnnom_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            txtnom.Enabled = true;
            txtnom.Focus();
            txtprenom.Enabled = false;
            cmbsexe.Enabled = false;
            rtbadresse.Enabled = false;
            msktelephone.Enabled = false;
            mskidentite.Enabled = false;
            txtemail.Enabled = false;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;        
            txtprenom.Enabled = true;
            txtprenom.Focus();
            txtnom.Enabled = false;
            cmbsexe.Enabled = false;
            rtbadresse.Enabled = false;
            msktelephone.Enabled = false;
            mskidentite.Enabled = false;
            txtemail.Enabled = false;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            txtnom.Enabled = false;
            cmbsexe.Enabled = true;
            //cmbsexe.Items.Add("Masculin");
            //cmbsexe.Items.Add("Feminin");
            cmbsexe.SelectedIndex = 0;
            cmbsexe.Focus();
            txtprenom.Enabled = false;
            rtbadresse.Enabled = false;
            msktelephone.Enabled = false;
            mskidentite.Enabled = false;
            txtemail.Enabled = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {

            groupBox1.Visible = false;
            txtnom.Enabled = false;
            msktelephone.Enabled = true;
            msktelephone.Focus();
            txtprenom.Enabled = false;
            cmbsexe.Enabled = false;
            rtbadresse.Enabled = false;
            txtemail.Enabled = false;
         
            mskidentite.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            txtemail.Enabled = false;

            txtnom.Enabled = false;
            txtprenom.Enabled = false;
            cmbsexe.Enabled = false;
            rtbadresse.Enabled = true;
            rtbadresse.Focus();
            msktelephone.Enabled = false;
            mskidentite.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtnom.Enabled = false;
            //rdNif.Checked = true;
            groupBox1.Visible = true;
            mskidentite.Visible = false;
            mskidentite.Visible = true;
            mskidentite.Focus();
            txtprenom.Enabled = false;
            cmbsexe.Enabled = false;
            rtbadresse.Enabled = false;
            msktelephone.Enabled = false;
            mskidentite.Enabled = true;
            txtemail.Enabled = false;

        }

        private void rdNif_CheckedChanged(object sender, EventArgs e)
        {
            mskidentite.Clear();
            mskidentite.Focus();
            mskidentite.Mask = ("000-000-000-0");
        }

        private void rdCin_CheckedChanged(object sender, EventArgs e)
        {
            mskidentite.Clear();
            mskidentite.Focus();
            mskidentite.Mask = ("00-00-00-0000-00-00000");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtnom.Enabled == false & txtprenom.Enabled == false & cmbsexe.Enabled == false & mskidentite.Enabled == false & msktelephone.Enabled == false & rtbadresse.Enabled == false)
            {
                MessageBoxOptions.DefaultDesktopOnly.ToString();
                MessageBox.Show("Aucune information n'a été modifiée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                //client cd =new client(txtid.Text,txtnom.Text,txtprenom.Text,cmbsexe.SelectedItem.ToString(),rtbadresse.Text,maskedTextBox1.Text,mskidentite.Text);

               int mod=0;
              
                   string co=txtid.Text;
                string nomm= txtnom.Text;
                string prenomm= txtprenom.Text;
                
                string sex= cmbsexe.SelectedItem.ToString();
                
                   string ad= rtbadresse.Text;
               string tel= msktelephone.Text;
               string iden= mskidentite.Text;
               string emai = txtemail.Text;
               if (txtnom.Text.Equals("")) {

                   nomm = nom;                   
               }
               if (txtprenom.Text.Equals(""))
               {

                   prenomm = prenom;
               }
               if (cmbsexe.SelectedItem.ToString().Equals(""))
               {

                   sex = sexe;
               } if (rtbadresse.Text.Equals(""))
               {

                   ad = adresse;
               }
               if (msktelephone.Text.Equals(""))
               {

                   tel = telephone;
               } if (mskidentite.Text.Equals(""))
               {

                   iden = identite;
               } if (txtemail.Text.Equals(""))
               {

                   emai = email;
               }
                 mod = Ut.Modifier( co,nomm,prenomm,sex,ad,tel,iden,emai);  
                if (mod == 0)
                   {
                       MessageBox.Show("Modification echouée!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   }
                   else {
                       MessageBox.Show("Modification réussie!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       txtid.Clear();

                       txtnom.Clear();
                       txtprenom.Clear();
                       cmbsexe.SelectedIndex = 0;
                     msktelephone.Clear();
                       rtbadresse.Clear();
                       rdNif.Select();
                       mskidentite.Clear();
                   }
            }
        }

        private void txtnom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString().ToUpper(), @"[^A-Z a-z/./ /-]"))
            {
                e.Handled = true;
            }
            else { e.Handled = false; }
            if (e.KeyChar == (char)8) { e.Handled = false; }
        }

        private void txtprenom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString().ToUpper(), @"[^A-Z a-z/./ /-]"))
            {
                e.Handled = true;
            }
            else { e.Handled = false; }
            if (e.KeyChar == (char)8) { e.Handled = false; }
        }

        private void msktelephone_TextChanged(object sender, EventArgs e)
        {
            if ((msktelephone.Text.Length == 14) && ((mskidentite.Text.Length == 13) || (mskidentite.Text.Length == 22)))
            {
                btnmodifier.Enabled = true;

            }
            else
            {
                btnmodifier.Enabled = false;
            }
        }

        private void mskidentite_TextChanged(object sender, EventArgs e)
        {
            if ((msktelephone.Text.Length == 14) && ((mskidentite.Text.Length == 13) || (mskidentite.Text.Length == 22)))
            {
                btnmodifier.Enabled = true;

            }
            else
            {
                btnmodifier.Enabled = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            txtprenom.Enabled = false;
            txtemail.Enabled = true;
            txtemail.Focus();
            txtnom.Enabled = false;
            cmbsexe.Enabled = false;
            rtbadresse.Enabled = false;
            msktelephone.Enabled = false;
            mskidentite.Enabled = false;
        }


    }
}
