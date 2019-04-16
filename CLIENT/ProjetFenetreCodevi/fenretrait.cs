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
    public partial class Fenretrait: Form
    {
        public TcpChannel tcp = null;
        public InterfaceClient objetclient = null;
        public InterfaceCompte objetcompte = null;
        public InterfaceUtilisateur objetutilisateur = null;
        public InterfacePret objetpret = null;

        public Fenretrait()
        {
            tcp = new TcpChannel();
            objetclient = (InterfaceClient)Activator.GetObject(typeof(InterfaceClient), "tcp://localhost:6060/objetclient");
            objetcompte = (InterfaceCompte)Activator.GetObject(typeof(InterfaceCompte), "tcp://localhost:6060/objetcompte");
            objetpret = (InterfacePret)Activator.GetObject(typeof(InterfacePret), "tcp://localhost:6060/objetpret");
            objetutilisateur = (InterfaceUtilisateur)Activator.GetObject(typeof(InterfaceUtilisateur), "tcp://localhost:6060/objetutilisateur");


            InitializeComponent();
          
            
        }

        private void Fendepot_Load(object sender, EventArgs e)
        {
           
            this.Size = new Size(435, 182);
            txtcodecompte.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int validite = 0;      
            
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

                   bool  cl = objetcompte.RechercherCompte(txtcodecompte.Text);
                    string devise = objetcompte.RecupererDevise();
                    if (!cl.Equals(false))
                     
                   {

                       string et = objetcompte.RecupererEtat();
                        if (et.Equals("desactiver"))
                        {
                            validite = 1;
                            MessageBox.Show("Ce compte est inactif", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else {
                            this.Size = new Size(435, 330);                           
                            txtdepot.Enabled = true;
                            txtmontant.Text = objetcompte.RecupererSolde() + " " + devise;
                            txtdepot.Focus();
                            bteffectuer.Enabled = true;
                            btannuler.Enabled = true;
                           
                        }
                        
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Compte inexistant", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }

        }

        private void bteffectuer_MouseHover(object sender, EventArgs e)
        {

        }

        private void bteffectuer_Click(object sender, EventArgs e)
        {
            int validite = 0;
            float test1 = 0;


           bool  cl = objetcompte.RechercherCompte(txtcodecompte.Text);
           string devise = objetcompte.RecupererDevise();
           test1 = objetcompte.RecupererSolde();

            try
            {
                if (txtdepot.Text.Equals(""))
                {
                    validite = 1;
                    MessageBox.Show("Entrer le montant", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                 
                else if (float.Parse(txtdepot.Text) <= 0)
                {

                    validite = 1;
                    MessageBox.Show("Valeur ne doit pas etre inferieur ou egal a Zero", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            catch
            {
                validite = 1;
                MessageBox.Show("Entrer uniquement des valeurs Numeriques", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }




            String d2 = System.DateTime.Now.ToShortDateString();
            try
            {
                if (float.Parse(txtdepot.Text) > test1)
                {


                    MessageBox.Show("Le montant ne doit pas depasser le solde du compte", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    validite = 1;

                }
                else if (objetcompte.RecupererDevise().Equals("Gourdes") && ((test1 - float.Parse(txtdepot.Text)) < 100))
                {


                    MessageBox.Show("Le solde restant ne doit pas etre inferieur a 100 gourdes", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    validite = 1;

                }
                else if (objetcompte.RecupererDevise().Equals("Dollards") && ((test1 - float.Parse(txtdepot.Text)) < 5))
                {
                    MessageBox.Show("Le solde restant ne doit pas etre inferieur a 5 dollards", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    validite = 1;
                }

                if (validite != 1)
                {

                    float conversion;
                    conversion = float.Parse(txtdepot.Text);

                    float nouveausolde;

                    nouveausolde = objetcompte.retraitcompte(objetcompte.RecupererSolde(), conversion);
                     DialogResult choix= MessageBox.Show("Voulez-vous effectuer le retrait?\n\nLe compte va être credité de: " + conversion + " " + devise, "confirmation", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
               if (choix.Equals(DialogResult.Yes))
               {
                    string test = null;
                    test = objetcompte.Depotcompte(txtcodecompte.Text, nouveausolde);
                    string description = "Retrait";
                   if(test!=null){
                       MessageBox.Show("Le retrait a été effectué", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    string nomutilisateur = fenConnection.nomutilisateur;
                    objetpret.EnregistrerTransaction(txtcodecompte.Text, description, float.Parse(txtdepot.Text), DateTime.Parse(d2), nomutilisateur);
                    objetutilisateur.RetracerOperation(fenConnection.nomutilisateur, description,fenConnection.adressemac());
                    this.Size = new Size(435, 182);

                    txtcodecompte.Focus();
                    txtcodecompte.Text = "";
                    txtdepot.Text = "";
                    txtmontant.Text = "";
                    }
                   else
                   {
                       MessageBox.Show("Retrait non effectué", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   }
               }else if(choix.Equals(DialogResult.No)){
               this.Close();
               }



                    //MessageBox.Show("Transcation effectuer avec succes. \nLe compte a été credité de: " + conversion + " " + devise);


                   

                }

            }catch(Exception){}
        }


        private void cmbdevise_SelectionChangeCommitted(object sender, EventArgs e)
        {

           bool  cl = objetcompte.RechercherCompte(txtcodecompte.Text);
            string devise =objetcompte.RecupererDevise();          
           
        }

        private void btannuler_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txtcodecompte_Click(object sender, EventArgs e)
        {
            if (txtcodecompte.Text.Equals("Remplissez le champ"))
            {

                txtcodecompte.Text = "";
               
            }
           
           
        }

        private void txtcodecompte_TextChanged(object sender, EventArgs e)
        {
            this.Size = new Size(435, 182);
            txtdepot.Clear();
        }
    }
}
