
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
    public partial class Fendepot : Form
    {
        public static InterfaceCompte objetcompte = null;
        public static InterfaceUtilisateur objetUtilisateur = null;

        public static InterfacePret objetpret = null;

        public static TcpChannel tcp = null;
        public Fendepot()
        {
            tcp = new TcpChannel();
            //ChannelServices.RegisterChannel(tcp);

            objetcompte = (InterfaceCompte)Activator.GetObject(typeof(InterfaceCompte), "tcp://localhost:6060/objetcompte");
            objetpret = (InterfacePret)Activator.GetObject(typeof(InterfacePret), "tcp://localhost:6060/objetpret");
            objetUtilisateur = (InterfaceUtilisateur)Activator.GetObject(typeof(InterfaceUtilisateur), "tcp://localhost:6060/objetutilisateur");


            InitializeComponent();
          
            
        }

        private void Fendepot_Load(object sender, EventArgs e)
        {
            cmbdevise.SelectedIndex = 0;
            this.Size = new Size(454, 205);
            txtcodecompte.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
            int validite = 0;
            
        

            if (txtcodecompte.Text.Equals(""))
            {

                validite = 1;
               

                
                MessageBox.Show("Remplissez le champ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {

                   
                   bool cl = objetcompte.RechercherCompte(txtcodecompte.Text);
                    string devise = objetcompte.RecupererDevise();
                     
                    if (!cl.Equals(false))
                     
                   { 

                        string et = objetcompte.RecupererEtat();
                        if (et.Equals("desactiver"))
                        {
                            validite = 1;
                            MessageBox.Show("Ce compte est inactif", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                        }
                        else {
                            this.Size = new Size(454, 415);

                           
                            txtdepot.Enabled = true;
                            
                            txtmontant.Text = objetcompte.RecupererSolde()+" "+devise;
                           
                            bteffectuer.Enabled = true;
                            btannuler.Enabled = true;
                            txtdepot.Select();
                            cmbdevise.Text = devise;
                        }
                        
                    }
                 

                }
                catch (Exception)
                {
                    MessageBox.Show("Compte inexistant");
                }


            }

        }

        private void bteffectuer_MouseHover(object sender, EventArgs e)
        {

        }

        private void bteffectuer_Click(object sender, EventArgs e)
        {
             int validite = 0;
             float taux = 1;
            

             
           bool  cl = objetcompte.RechercherCompte(txtcodecompte.Text);
             string devise = objetcompte.RecupererDevise();

             try
             {
                 if (txtdepot.Text.Equals(""))
                 {
                     validite = 1;
                     MessageBox.Show("Champ depot vide");

                 }
                 else if (float.Parse(txtdepot.Text) <= 0)
                 {

                     validite = 1;
                     MessageBox.Show("Valeur ne doit pas etre inferieur a Zero");
                 }
             }
            
                 catch
            {
                validite = 1;
                MessageBox.Show("Entrer des valeurs Numeriques pour le montant", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);


             }
             if ((cmbdevise.Text != devise))
             {

                 try
                 {
                     if (txttaux.Text.Equals(""))
                     {

                         MessageBox.Show("Champ taux vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                         validite = 1;
                     }
                     else if (float.Parse(txttaux.Text) <= 0)
                     {

                         MessageBox.Show("La valeur ne doit pas etre inferieur a Zero", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                         validite = 1;
                     }
                     else if (float.Parse(txttaux.Text) >=1000)
                     {

                         MessageBox.Show("La valeur ne doit pas etre superieur ou egal a 1000 Gourdes", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                         validite = 1;
                     }
                 }

                 catch
                 {

                     MessageBox.Show("Valeur Numerique requise pour le taux", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     validite = 1;
                 }
                 if (validite != 1)
                 {

                     if (cmbdevise.Equals("Dollards") || (devise.Equals("Gourdes")))
                     {
                         //validite = 0;
                         taux = 1 * float.Parse(txttaux.Text);

                     }
                     else
                         taux = 1 / float.Parse(txttaux.Text);

                 }
             }

            if( validite!=1){
               
             String d2 = System.DateTime.Now.ToShortDateString();
             
                float conversion;
             conversion = float.Parse(txtdepot.Text) * taux;

            




                float nouveausolde;

                nouveausolde = objetcompte.depotcompte(objetcompte.RecupererSolde(), conversion);


               DialogResult choix= MessageBox.Show("Voulez-vous effectuer le depot?\n\nLe compte va être debité de " + conversion + " " + devise, "confirmation", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
               if (choix.Equals(DialogResult.Yes))
               {
                   string test = null;
                   test = objetcompte.Depotcompte(txtcodecompte.Text, nouveausolde);
                   string description = "Depot";

                   if (test != null)
                   {
                       MessageBox.Show("Le depot a été effectué", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       string nomutilisateur = fenConnection.nomutilisateur;
                       objetpret.EnregistrerTransaction(txtcodecompte.Text, description, float.Parse(txtdepot.Text), DateTime.Parse(d2), nomutilisateur);
                       objetUtilisateur.RetracerOperation(fenConnection.nomutilisateur, description,fenConnection.adressemac());
                       //MessageBox.Show(" \nLe compte a ete debite de " + conversion + " " + devise);
                       cmbdevise.SelectedIndex = 0;
                       this.Size = new Size(454, 205);
                       txtcodecompte.Focus();
                       txtcodecompte.Text = "";
                       txtdepot.Text = "";
                       txtmontant.Text = "";
                       lbresultat.Visible = false;
                       lbresultat.Text = "";
                       lbtaux.Visible = false;
                       txttaux.Visible = false;
                       txttaux.Clear();
                   }
                   else
                   {
                       MessageBox.Show("Depot non effectué", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   }
               }else if(choix.Equals(DialogResult.No)){
                   txtcodecompte.Clear();
                   txtcodecompte.Select();
                   txtmontant.Clear();
                   txtdepot.Clear();
                   cmbdevise.SelectedIndex = 0;
                   txttaux.Clear();
                   this.Size = new Size(454, 205);

               }
            
            }

        }

        private void cmbdevise_SelectionChangeCommitted(object sender, EventArgs e)
        {

           
           bool cl = objetcompte.RechercherCompte(txtcodecompte.Text);
            string devise = objetcompte.RecupererDevise();

            if ((cmbdevise.Text != devise))
            {
                txttaux.Clear();
                lbtaux.Visible = true;
                txttaux.Visible = true;

            }
            else if ((cmbdevise.Text == devise)) {
                txttaux.Clear();
                lbtaux.Visible = false;
                txttaux.Visible = false;
            }
           
        }

        private void txtdepot_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttaux_TextChanged(object sender, EventArgs e)
        {

        }

        private void btannuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtcodecompte_Click(object sender, EventArgs e)
        {
            if (txtcodecompte.Text.Equals("Remplissez le champ"))
            {
                this.Size = new Size(454, 205);

                txtcodecompte.Text = "";
            }

            //cmbdevise.SelectedIndex = 0;
            //this.Size = new Size(454, 205);
            txtcodecompte.Focus();
            //txtmontant.Clear();
            //txtdepot.Clear();
            //cmbdevise.SelectedIndex = 0;
            //txttaux.Clear();
            txttaux.Visible = false;
            lbtaux.Visible = false;
        }

        private void txtcodecompte_TextChanged(object sender, EventArgs e)
        {
            this.Size = new Size(454, 205);
            txtdepot.Clear();
        }
    }
}
