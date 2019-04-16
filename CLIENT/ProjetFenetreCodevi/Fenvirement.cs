
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
    public partial class Fenvirement : Form
    {
        public TcpChannel tcp = null;
        public InterfaceClient objetclient = null;
        public InterfaceCompte objetcompte = null;
        public InterfaceUtilisateur objetutilisateur = null;
        public InterfacePret objetpret = null;
        public Fenvirement()
        {
            tcp = new TcpChannel();
            objetclient = (InterfaceClient)Activator.GetObject(typeof(InterfaceClient), "tcp://localhost:6060/objetclient");
            objetcompte = (InterfaceCompte)Activator.GetObject(typeof(InterfaceCompte), "tcp://localhost:6060/objetcompte");
            objetpret = (InterfacePret)Activator.GetObject(typeof(InterfacePret), "tcp://localhost:6060/objetpret");
            objetutilisateur = (InterfaceUtilisateur)Activator.GetObject(typeof(InterfaceUtilisateur), "tcp://localhost:6060/objetutilisateur");
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Fenvirement_Load(object sender, EventArgs e)
        {
            this.Size = new Size(505, 295);
            txtcodecompte2.Focus();
            

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (txtcodecompte2.Text.Equals("Remplissez ce champ"))
            {

                txtcodecompte2.Text = "";
            }
            if (txtcodecompte1.Text.Equals(""))
            {

                txtcodecompte1.Visible = true;
                txtcodecompte1.Text = "Remplissez ce champ";
            }
            else if (txtcodecompte1.Text.Equals("Remplissez ce champ"))
            {
                txtcodecompte1.Text = "";
            }
            else
            {
                try
                {
                    if (txtcodecompte1.Text.Equals("Remplissez ce champ"))
                    {

                        txtcodecompte1.Text = "";
                    }
                    else
                    {
                       bool cl = objetcompte.RechercherCompte(txtcodecompte1.Text);
                        string devise = objetcompte.RecupererDevise();
                        if (!cl.Equals(false))
                        {

                            string et = objetcompte.RecupererEtat();
                            if (et.Equals("desactiver"))
                            {

                                lberrorcp1.Visible = true;
                               

                                lberrorcp1.Text = "Compte inactif";


                            }
                            else
                            {

                                lberrorcp1.Visible = true;

                                lberrorcp1.Text = objetcompte.RecupererSolde() + " " + devise;
                            }

                        }

                    }
                }
                catch (Exception)
                {
                    // MessageBox.Show("Compte inexistant");

                    lberror1.Visible = true;
                    lberrorcp1.Visible = true;

                    lberrorcp1.Text = "Compte inexistant";
                }
            }
            

            

        }

        private void txtcodecompte1_MouseClick(object sender, MouseEventArgs e)
        {
            lberror1.Visible = false;
            lberrorcp1.Visible = false;

           
        }

        private void txtmontant_Click(object sender, EventArgs e)
        {
            if (txtcodecompte1.Text.Equals(""))
            {


                //txtcodecompte1.Text = "Remplissez ce champ";


            }
            else 
            {
                try
                {
            //        if (txtcodecompte1.Equals("Remplissez ce champ"))
            //{
            //    txtcodecompte1.Text = "";
            //}
                    txtcodecompte1.Text = "";
                   bool cl = objetcompte.RechercherCompte(txtcodecompte1.Text);
                   string devise = objetcompte.RecupererDevise();
                    if (!cl.Equals(false))
                    {

                        string et = objetcompte.RecupererEtat();
                        if (et.Equals("inactif"))
                        {

                            lberrorcp1.Visible = true;
                            lberrorcp1.ForeColor = Color.Red;

                            lberrorcp1.Text = "Compte inactif";


                        }
                        else
                        {
                            lberrorcp1.Visible = true;
                            lberrorcp1.Text = objetcompte.RecupererSolde() + " " + devise;
                        }

                    }

                }
                catch (Exception)
                {
                    // MessageBox.Show("Compte inexistant");

                    lberror1.Visible = true;
                    lberrorcp1.Visible = true;
                    lberrorcp1.Text = "Compte inexistant";
                }


            }

            //////////////////////////////////////////////////////////////////////
            if (txtcodecompte2.Text.Equals(""))
            {

                txtcodecompte2.Visible = true;
                txtcodecompte2.Text = "Remplissez ce champ";


            }
            else
            {
                try
                {

                   bool cl = objetcompte.RechercherCompte(txtcodecompte2.Text);
                   string devise = objetcompte.RecupererDevise();
                    if (!cl.Equals(null))
                    {

                        string et = objetcompte.RecupererEtat();
                        if (et.Equals("inactif"))
                        {

                            lberrorcp2.Visible = true;
                            lberrorcp2.ForeColor = Color.Red;

                            lberrorcp2.Text = "Compte inactif";


                        }
                        else
                        {

                            lberrorcp2.Visible = true;

                            lberrorcp2.Text = objetcompte.RecupererSolde() + " " + devise;
                        }

                    }

                }
                catch (Exception)
                {
                    // MessageBox.Show("Compte inexistant");

                    lberror2.Visible = true;
                    lberrorcp2.Visible = true;

                    lberrorcp2.Text = "Compte inexistant";
                }


            }

        }

        private void textBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtcodecompte2_MouseClick(object sender, MouseEventArgs e)
        {
            lberror2.Visible = false;
            lberrorcp2.Visible = false;
        }

        private void textBox2_Click_1(object sender, EventArgs e)
        {
            int validite = 0;
           
            if (txtmontant.Text.Equals("Champ montant vide"))
            {

                txtmontant.Text = "";
                validite = 1;
            }        
            
            
            
            
            string devise1 = "";
            string devise2 = "";
            string code1 = "a";
            string code2 = "";



            if (txtcodecompte1.Text.Equals(""))
            {

                txtcodecompte1.Visible = true;
                txtcodecompte1.Text = "Remplissez ce champ";
                validite = 1;            }
            else
            {
                try
                {
                    if (txtcodecompte1.Text.Equals("Remplissez ce champ"))
                    {
                        validite = 1;
                        txtcodecompte1.Text = "";
                    }
                    else
                    {
                       bool cl = objetcompte.RechercherCompte(txtcodecompte1.Text);
                       devise1 = objetcompte.RecupererDevise();
                       code1 = objetcompte.RecupererNumeroCompte();
                        if (!cl.Equals(null))
                        {

                            string et = objetcompte.RecupererEtat();
                            if (et.Equals("desactiver"))
                            {
                                validite = 1;
                                lberrorcp1.Visible = true;
                              

                                lberrorcp1.Text = "Compte inactif";


                            }
                            else
                            {

                                lberrorcp1.Visible = true;

                                lberrorcp1.Text = objetcompte.RecupererSolde() + " " + devise1;
                                lbdevise.Visible = true;
                                lbdevise.Text = " " + devise1;
                            }

                        }

                    }
                }
                catch (Exception)
                {
                    // MessageBox.Show("Compte inexistant");

                    lberror1.Visible = true;
                    lberrorcp1.Visible = true;

                    lberrorcp1.Text = "Compte inexistant";
                    validite = 1;
                }
            }
            
//////////////////////////////////////////////////////////////////////////////////////////////////////////////



            {
                if (txtcodecompte2.Text.Equals(""))
                {

                    txtcodecompte2.Visible = true;
                    txtcodecompte2.Text = "Remplissez ce champ";
                    validite = 1;


                }
                else
                {
                    try
                    {
                        if (txtcodecompte2.Text.Equals("Remplissez ce champ"))
                        {

                            txtcodecompte2.Text = "";
                            validite = 1;
                        }
                        else
                        {
                          bool  cl = objetcompte.RechercherCompte(txtcodecompte2.Text);
                          devise2 = objetcompte.RecupererDevise();
                          code2 = objetcompte.RecupererNumeroCompte();
                            if (!cl.Equals(null))
                            {

                                string et = objetcompte.RecupererEtat();
                                if (et.Equals("desactiver"))
                                {
                                    validite = 1;
                                    lberrorcp2.Visible = true;
                                    

                                    lberrorcp2.Text = "Compte inactif";


                                }
                                else
                                {

                                    lberrorcp2.Visible = true;

                                    lberrorcp2.Text = objetcompte.RecupererSolde() + " " + devise2;
                                }

                            }

                        }
                    }
                    catch (Exception)
                    {
                        // MessageBox.Show("Compte inexistant");

                        lberror2.Visible = true;
                        lberrorcp2.Visible = true;

                        lberrorcp2.Text = "Compte inexistant";
                        validite = 1;
                    }
                }

              
            }

            if (code1.Equals(code2))
            {
                MessageBox.Show("Transaction impossible car les comptes sont identiques! ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Size = new Size(505, 295);
                validite = 1;
            }

            if (validite != 1)
            {
                if (devise1 != devise2)
                {
                    this.Size = new Size(484, 389);
                    lbtaux.Visible = true;
                    txttaux.Visible = true;
                   
                }
                if (devise1.Equals(devise2))
                {

                   
                    this.Size = new Size(484, 384);
                    lbtaux.Visible = false;
                    txttaux.Visible = false;
                }
            }
        }

        private void txtcodecompte1_Click(object sender, EventArgs e)
        {
            if (txtcodecompte1.Text.Equals("Remplissez ce champ"))
            {

                txtcodecompte1.Text = "";
            }
        }

        

        private void txttaux_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmontant.Text.Equals(""))
                {
                   
                    MessageBox.Show("Champ montant vide");

                }
                else if (float.Parse(txtmontant.Text) <= 0)
                {


                    MessageBox.Show("La valeur du montant ne doit pas etre inferieur a Zero", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            catch
            {

                MessageBox.Show("Le champ montant doit avoir uniquement des valeurs numeriques", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtmontant_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool c = objetcompte.RechercherCompte(txtcodecompte1.Text);
            string devis1 = objetcompte.RecupererDevise();

          bool  c2 = objetcompte.RechercherCompte(txtcodecompte2.Text);
          string devis2 = objetcompte.RecupererDevise();

            int validite = 0;
            if (devis1 == devis2)
            {
               
                lbtaux.Visible = false;
                txttaux.Visible = false;

            }
            else
            {
            
                lbtaux.Visible = true;
                txttaux.Visible = true;
            }

            try
            {
                if (txtmontant.Text.Equals(""))
                {

                    MessageBox.Show("Le champ montant est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    validite = 1;

                }
                else if (float.Parse(txtmontant.Text) <= 0)
                {

                    validite = 1;

                    MessageBox.Show("La Valeur du montant ne doit pas etre inferieur a Zero", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            catch
            {

                MessageBox.Show("Le champ montant doit avoir uniquement des valeurs numeriques", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                validite = 1;
            }



            if (validite == 0)
            {

                try
                {
                    if (txttaux.Visible != false)                   {
                       
                       
                        if (txttaux.Text.Equals(""))
                        {
                        
                        
                        DialogResult choix=  MessageBox.Show("Entrer le taux");
                        
                          if (choix.Equals(DialogResult.OK)) {
                              lbtaux.Visible = true;
                              txttaux.Visible = true;
                              txttaux.Enabled = true;
                          }

                            lbtaux.Visible = true;
                            txttaux.Visible = true;
                            txttaux.Enabled = true;
                           
                            validite = 1;
                        }
                        else if (float.Parse(txttaux.Text) <= 0)
                        {
                            MessageBox.Show("La valeur du taux ne doit pas etre inferieur a Zero", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            validite = 1;


                        }
                    }
                }


                catch
                {


                    MessageBox.Show("Le taux doit etre une valeur numerique", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    validite = 1;


                }



            }

            //////////////////////////////////////////////////////////////////////////////////

            if (txtmontant.Text.Equals("Champ montant vide"))
            {

                validite = 1;

                MessageBox.Show("Le champ montant est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }





            string devise1 = "";
            string devise2 = "";
            string code1 = "a";
            string code2 = "";
            float solde1 = 0;
            float solde2 = 0;



            if (txtcodecompte1.Text.Equals(""))
            {

                validite = 1;
                MessageBox.Show("Champ compte debiteur  vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                try
                {
                    if (txtcodecompte1.Text.Equals("Remplissez ce champ"))
                    {

                        validite = 1;
                        MessageBox.Show("Champ compte debiteur  vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                       bool cl = objetcompte.RechercherCompte(txtcodecompte1.Text);
                       devise1 = objetcompte.RecupererDevise();
                       code1 = objetcompte.RecupererNumeroCompte();
                       solde1 = objetcompte.RecupererSolde();
                        if (!cl.Equals(null))
                        {

                            string et = objetcompte.RecupererEtat();
                            if (et.Equals("desactiver"))
                            {


                                validite = 1;
                                MessageBox.Show("Compte debiteur  inactif");


                            }
                            else
                            {

                                ////////////////anyen/////////////////////////
                            }

                        }

                    }
                }
                catch (Exception)
                {
                    // MessageBox.Show("Compte inexistant");

                    MessageBox.Show("Compte debiteur n'existe pas", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    validite = 1;

                }
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////



            {
                if (txtcodecompte2.Text.Equals(""))
                {


                    MessageBox.Show("Compte crediteur vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    validite = 1;
                }
                else
                {
                    try
                    {
                        if (txtcodecompte2.Text.Equals("Remplissez ce champ"))
                        {

                            MessageBox.Show("Compte crediteur vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            validite = 1;
                        }
                        else
                        {
                           bool cl = objetcompte.RechercherCompte(txtcodecompte2.Text);
                           devise2 = objetcompte.RecupererDevise();
                           code2 = objetcompte.RecupererNumeroCompte();
                           solde2 = objetcompte.RecupererSolde();
                            if (!cl.Equals(null))
                            {

                                string et = objetcompte.RecupererEtat();
                                if (et.Equals("desactiver"))
                                {

                                    MessageBox.Show("Compte crediteur inactif", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    validite = 1;


                                }
                                else
                                {

                                    /////////////////anyen//////////////////////////
                                }

                            }

                        }
                    }
                    catch (Exception)
                    {
                        // MessageBox.Show("Compte inexistant");

                        MessageBox.Show("Le compte crediteur n'existe pas");
                        validite = 1;
                    }
                }


            }
            if (devise1.Equals(devise2))
            {


                this.Size = new Size(484, 384);
                lbtaux.Visible = false;
                txttaux.Visible = false;


            }
            else
            {

                this.Size = new Size(484, 389);
                lbtaux.Visible = false;
                txttaux.Visible = false;

            }


            if (validite != 1)
            {
                float taux = 1;
                float montant = 0;
                float sol2 = 0;
                float sol1 = 0;

                if (devise1.Equals("Gourdes") && devise2.Equals("Gourdes"))
                {

                    txttaux.Visible = false;
                    lbtaux.Visible = false;

                    montant = float.Parse(txtmontant.Text);

                    sol2 = objetcompte.depotcompte(solde2, montant);

                    sol1 = objetcompte.retraitcompte(solde1,montant);

                  
                }
                else if (devise1.Equals("Dollards") && devise2.Equals("Dollards"))
                {
                    txttaux.Visible = false;
                    lbtaux.Visible = false;




                    montant = float.Parse(txtmontant.Text);
                    sol2 = objetcompte.depotcompte(solde2, montant);

                    sol1 = objetcompte.retraitcompte(solde1,montant);
                  

                }

                   /////// crediteur ak debiteur nan plas yo


                else if (devise1.Equals("Gourdes") && devise2.Equals("Dollards"))
                {
                    txttaux.Visible = true;
                    lbtaux.Visible = true;



                    montant = float.Parse(txtmontant.Text) / float.Parse(txttaux.Text);

                    sol2 = objetcompte.depotcompte(montant, solde2);
                    sol1 = objetcompte.retraitcompte(solde1, float.Parse(txtmontant.Text));

                    

                }
                else if (devise1.Equals("Dollards") && devise2.Equals("Gourdes"))
                {

                    txttaux.Visible = true;
                    lbtaux.Visible = true;



                    montant = float.Parse(txtmontant.Text) * float.Parse(txttaux.Text);

                    sol2 = objetcompte.depotcompte(montant, solde2);
                    sol1 = objetcompte.retraitcompte(solde1, float.Parse(txtmontant.Text));

                    



                }

                if (devise1.Equals("Gourdes") && (solde1 - (float.Parse(txtmontant.Text)) < 100))
                {

                    MessageBox.Show("La valeur qui restera sur le compte crediteur \nne doit pas etre inferieur a 100 " + devise1, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    validite = 1;

                }
                else if (devise1.Equals("Dollards") && (solde1 - (float.Parse(txtmontant.Text)) < 5))
                {
                    MessageBox.Show("La valeur qui restera sur le compte crediteur \nne doit pas etre inferieur a 5 " + devise1, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    validite = 1;

                }

                if (validite != 1)
                {
                    string description = "Virement";
                    string nomutilisateur = fenConnection.nomutilisateur;
                    string succes=null;
                    int validite2;

                    String d2 = System.DateTime.Now.ToShortDateString();

                    
                    succes=objetcompte.Depotcompte(txtcodecompte1.Text, sol1);
                    if (succes == null)
                    {

                        MessageBox.Show("Action non reussie sur le compte crediteur", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        validite2 = 1;
                    }
                    else
                    {
                        // MessageBox.Show("Action  reussite pour le compte crediteur");
                    }
                    string test = null;
                    test = objetcompte.Depotcompte(txtcodecompte2.Text,sol2);

                    if (test == null)
                    {

                        MessageBox.Show("Action non reussie sur le compte debiteur", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        validite2 = 1;
                    }
                    else
                    {
                        // MessageBox.Show("Action  reussite pour le compte debiteur");
                    }

                    

                    objetpret.EnregistrerTransaction(txtcodecompte1.Text, description, float.Parse(txtmontant.Text), DateTime.Parse(d2), nomutilisateur);
                    objetpret.EnregistrerTransaction(txtcodecompte2.Text, description, montant, DateTime.Parse(d2), nomutilisateur);
                    objetutilisateur.RetracerOperation(fenConnection.nomutilisateur, "Virement",fenConnection.adressemac());
                    MessageBox.Show("Virement effectué avec succès!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtcodecompte1.Clear();
                    txtcodecompte2.Clear();
                    txtmontant.Clear();
                    txttaux.Visible = false;
                    lbtaux.Visible = false;
                    txttaux.Clear();
                    lberrorcp1.ResetText();
                    lberrorcp2.ResetText();
                }
            }
        }

        

        private void txtcodecompte1_TextChanged(object sender, EventArgs e)
        {
            this.Size = new Size(505, 295);
            txtcodecompte1.Focus();
            txtmontant.Text = "";
            txttaux.Visible = false;
            lbtaux.Visible = false;
            lbdevise.Visible = false;
           
        }

        private void txtcodecompte2_TextChanged(object sender, EventArgs e)
        {


            this.Size = new Size(505, 295);
       
            txtmontant.Text = "";
            txttaux.Visible = false;
            lbtaux.Visible = false;
            lbdevise.Visible = false;
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txttaux_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

