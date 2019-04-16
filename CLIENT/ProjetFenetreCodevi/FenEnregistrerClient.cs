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
using Com.ProjetCodevi.Interface;

using Com.ProjetCodevi.Service;
using System.Runtime.Remoting.Channels.Tcp;

namespace ProjetFenetreCodevi
{
    public partial class FenEnregistrerClient : Form
    {
        public static InterfaceCompte objetcompte = null;
        public static InterfaceClient objetClient = null;
        public static InterfaceUtilisateur objetUtilisateur = null;
        public static TcpChannel tcp = null;

        public FenEnregistrerClient()
        {
            tcp = new TcpChannel();
            objetcompte = (InterfaceCompte)Activator.GetObject(typeof(InterfaceCompte), "tcp://localhost:6060/objetcompte");
            objetClient = (InterfaceClient)Activator.GetObject(typeof(InterfaceClient), "tcp://localhost:6060/objetclient");
            objetUtilisateur = (InterfaceUtilisateur)Activator.GetObject(typeof(InterfaceUtilisateur), "tcp://localhost:6060/objetutilisateur");
            InitializeComponent();
        }
        public static string cod;
        private void FenEnregistrerClient_Load(object sender, EventArgs e)
        {
            cmbsexe.SelectedIndex = 0;
            rdNif.Checked = true;
            Random r = new Random();

            cod = String.Format("CL-{0}{1}", r.Next(0, 1000), r.Next(0, 2000));
            txtcode.Text = cod;
        }




        private void rdNif_CheckedChanged_1(object sender, EventArgs e)
        {
            mskidentite.Clear();
            mskidentite.Focus();
            mskidentite.Mask = ("000-000-000-0");
        }

        private void rdCin_CheckedChanged_1(object sender, EventArgs e)
        {
            mskidentite.Clear();
            mskidentite.Focus();
            mskidentite.Mask = ("00-00-00-0000-00-00000");
        }

        private void btannuler_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btsuivant_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtemail.Text.Trim(), "^[a-z][a-z0-9/./_/-/]+[@][a-z0-9]+[/.][a-z]{2,4}$"))
            {

                MessageBox.Show("Le format d'email entré est incorrect", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txttelephone.Text.Substring(5, 8), "^[4|2|3][0-9/-]{7}$"))
            {
                MessageBox.Show("Le numero de telephome est incorrect", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //rtbadresse.Enabled = false;
                
            }
            else   if (!mskidentite.MaskCompleted)
            {

                MessageBox.Show("Le Nif/Cin est incorrect!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                if (txtnom.Text.Equals("") || txtprenom.Text.Equals("") || rtbadresse.Text.Equals("") || txttelephone.Text.Equals("") || (mskidentite.Text.Equals(""))||txtemail.Text.Equals(""))
                {
                    MessageBox.Show("Tous les champs doivent etre remplis!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {



                  
                    DialogResult choix = MessageBox.Show("Informations entrées\n-----------------------------------\nCode:" + cod + "\nNom: " + txtnom.Text + "\nPrenom: " + txtprenom.Text + "\nTelephone: " + txttelephone.Text + "\nSexe: " + cmbsexe.SelectedItem.ToString() + "\nAdresse: " + rtbadresse.Text + "\nCin/Nif: " + mskidentite.Text, "Voulez-vous entregistrer?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (choix == DialogResult.Yes)
                    {
                        
                        Service ser=new Service();
                        MessageBox.Show(ser.EnvoyerEmail(txtemail.Text.Trim(),"petit.william32@gmail.com", "Nouveau client", "Bienvenue "+txtprenom.Text.Trim()+" "+txtnom.Text.Trim().ToUpper()+" à Codevi, votre numero d'identifiant est: "+cod+"\n\nNous sommes heureux de vous compter parmi nos clients!"));
                                              
                        int test;
                        test = objetClient.EnregistrerrClient(cod,txtnom.Text,txtprenom.Text,cmbsexe.SelectedItem.ToString(),rtbadresse.Text,txttelephone.Text,mskidentite.Text,txtemail.Text);
                        if (test != 0)
                        {
                            MessageBox.Show("Client Enregistré!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            objetUtilisateur.RetracerOperation(fenConnection.nomutilisateur, "Enregistrement client",fenConnection.adressemac());
                            txtcode.Clear();
                            txtnom.Clear();
                            txtprenom.Clear();
                            txtemail.Clear();
                            cmbsexe.SelectedIndex = 0;
                            txttelephone.Clear();
                            rtbadresse.Clear();
                            rdNif.Select();
                            mskidentite.Clear();
                            rdNif.Checked = true;
                            Random r = new Random();

                            cod = String.Format("CL-{0}{1}", r.Next(0, 1000), r.Next(0, 2000));
                            txtcode.Text = cod;
                        }
                        else
                        {
                            MessageBox.Show("Client non enregistré!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (choix.Equals(DialogResult.No))
                    {
                        txtnom.Clear();
                        txtprenom.Clear();
                        cmbsexe.SelectedIndex = 0;
                        txttelephone.Clear();
                        rtbadresse.Clear();
                        rdNif.Select();
                        mskidentite.Clear();
                    }
                    else
                    {


                    }

                }
            }
        }

        private void txtnom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString().ToUpper(), @"[^A-Z a-z 0-9/./ /-]"))
            {
                e.Handled = true;
            }
            else { e.Handled = false; }
            if (e.KeyChar == (char)8) { e.Handled = false; }
        }

        private void txtprenom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString().ToUpper(), @"[^A-Z a-z 0-9/./ /-]"))
            {
                e.Handled = true;
            }
            else { e.Handled = false; }
            if (e.KeyChar == (char)8) { e.Handled = false; }
        }

        private void mskidentite_TextChanged(object sender, EventArgs e)
        {
            if ((txttelephone.Text.Length == 14) && ((mskidentite.Text.Length == 13) || (mskidentite.Text.Length == 22)))
            {
                btsuivant.Enabled = true;

            }
            else {
                btsuivant.Enabled = false;
            }
        }

        private void txttelephone_TextChanged(object sender, EventArgs e)
        {
            if ((txttelephone.Text.Length == 14)&&(txtemail.Text!="") && ((mskidentite.Text.Length == 13) || (mskidentite.Text.Length == 22)))
            {
                btsuivant.Enabled = true;

            }
            else
            {
                btsuivant.Enabled = false;
            }
        }

        private void mskidentite_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txttelephone_Leave(object sender, EventArgs e)
        {

        }

        private void txttelephone_MouseLeave(object sender, EventArgs e)
        {

            


               
            }

        private void rtbadresse_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void rtbadresse_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //if (!System.Text.RegularExpressions.Regex.IsMatch(txttelephone.Text.Substring(5, 8), "^[4|2|3][0-9/-]{7}$"))
                if (!System.Text.RegularExpressions.Regex.IsMatch(txttelephone.Text.Substring(5, 8), "^[4|2|3][0-9/-]{7}$"))
                {
                    MessageBox.Show("Le numero de telephome est incorrect", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //rtbadresse.Enabled = false;
                    rtbadresse.Clear();
                }
                else
                {

                    rtbadresse.Enabled = true;
                    //MessageBox.Show("Le numero de telephome est incorrect");
                    //  goto tel;
                }
            }
            catch (Exception fdf) {
                //MessageBox.Show(fdf.Message);
            }
        }
                   
        
              
        

     

        //private void btsuivant_MouseHover(object sender, EventArgs e)
        //{
        //    rtbadresse.Text = "coucou";
        //    //rtbadresse.Location = new Point(e.x, e.y);
        //}

        //private void btsuivant_MouseLeave(object sender, EventArgs e)
        //{
        //    rtbadresse.Text = "";
        //}
    }
}
