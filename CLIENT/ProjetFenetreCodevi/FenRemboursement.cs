using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ProjetFenetreCodevi;
using Com.ProjetCodevi.Interface;
using System.Runtime.Remoting.Channels.Tcp;

namespace ProjetFenetreCodevi
{
    public partial class FenRemboursement : Form
    {
        public TcpChannel tcp = null;
        public InterfaceClient objetclient = null;
        public InterfaceCompte objetcompte = null;
        public InterfaceUtilisateur objetutilisateur = null;

        public InterfacePret P = null;
        public InterfacePret Pre = null;
        public InterfacePret Par = null;



        public FenRemboursement()
        {
            tcp = new TcpChannel();
            objetclient = (InterfaceClient)Activator.GetObject(typeof(InterfaceClient), "tcp://localhost:6060/objetclient");
            objetcompte = (InterfaceCompte)Activator.GetObject(typeof(InterfaceCompte), "tcp://localhost:6060/objetcompte");
            P = (InterfacePret)Activator.GetObject(typeof(InterfacePret), "tcp://localhost:6060/objetpret");
            Pre = (InterfacePret)Activator.GetObject(typeof(InterfacePret), "tcp://localhost:6060/objetpret");
            Par = (InterfacePret)Activator.GetObject(typeof(InterfacePret), "tcp://localhost:6060/objetpret");


            InitializeComponent();
        }
        public int difff = 0;
        public static float du = 0;
        public static float parmois;
        public int fini = 0;
        public float penalite = 0;
        public int enmois = 0;
        public float total = 0;
        public static float dwe=0;
        public static string req1;
        
        private void FenRemboursement_Load(object sender, EventArgs e)
        {
            lbpenalite.Visible = false;
            lbldifference.Visible = false;
            txtdifference.Visible = false;
            this.Size = new Size(370, 221);
            txtnumero.Focus();
            
            txtnumero.Select();
        }

        private void btannuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btrechercher_Click(object sender, EventArgs e)
        {

            if (txtnumero.Text.Equals(""))
            {
                txtnumero.ForeColor = Color.Red;
                txtnumero.Text = "Entrer le numero du compte";
            }

            else
            {
               bool p = P.RechercherPretarembourser(txtnumero.Text);
                bool pre = Pre.RechercherPret(txtnumero.Text);
                bool par = Par.RechercherParmois(txtnumero.Text);
                /*Condition permettant de tester si le numero du compte existe ou pas...............*/
               
                if ((p  != false)&&(pre!=false))
                {
                    this.Size = new Size(610, 350);
                    dwe = P.RecupererMontant();
                    lbldevise.Text = Pre.RecupererDevise();
                    
                    TimeSpan difdate =P.RecupererDateremise()- DateTime.Parse(P.RecupererDatepret())  ;
                   
                    difff= difdate.Days / 30;
                    //int date = int.Parse(p.getDatremiset().ToString("d"));
                    
                   
                    parmois =Par.RecupererMontant()/difff;
                    //MessageBox.Show(parmois + "");
                    lblinfo.Text = "\nNumero compte      : " + P.RecupererNumeroCompte() + "\n\nNumero Client      :   " + P.RecupererNumeroClient() + "\n\nMontant du pret       : " + Pre.RecupererMontant() + "\n\nMontant dû        : " + P.RecupererMontant() + "\n\nMontant par mois       : " + parmois + "\n\nDate Pret          :   " + P.RecupererDatepret() + "\n\nDate remise        :   " + P.RecupererDateremise().ToShortDateString();
                    txtmontant.Focus();
                    du = P.RecupererMontant();
                    //MessageBox.Show("" +p.getmontant());
                    string codeco = P.RecupererNumeroCompte();
                    DateTime dat = P.RecupererDateremise().Date;
                    DateTime dat2 = System.DateTime.Now.Date;
                    int comparaison = DateTime.Compare(dat.Date, dat2.Date);
                    string difference = null;
                    if (comparaison == 0)
                    {
                        difference = "est meme que";
                    }
                    else if (comparaison > 0)
                    {
                        difference = "est plus tard que";
                    }
                    else
                    {
                        difference = "est plus tot que";
                        if (dat.Year <= dat2.Year)
                        {
                            int diff = dat2.Month - dat.Month;
                            TimeSpan ts = dat2 - dat;
                            int differjour = ts.Days;
                            enmois = differjour / 30;
                            //MessageBox.Show("" + enmois);

                            //lbpenalite.Text = "Nombre de jours de retard     :" + differjour + "\nNombre de mois de retard      :" + enmois;
                           if (enmois > 0)
                            {   penalite = ((Pre.RecupererMontant() * (4 * enmois)) / 100);
                            total = penalite + P.RecupererMontant();
                                lbpenalite.Visible = true;
                                lbpenalite.Text = "vous avez une Penalite de     : " + penalite + "\nMontant total a payer         :" + total;
                                //parmois = parmois + (penalite / difff);
                                //MessageBox.Show("" + parmois);
                            }
                        }
                    }
                    
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    MessageBox.Show("Le numero entré n'est lie a aucun pret! ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Console.ForegroundColor = ConsoleColor.White;

                }
            }
        }
                           

        private void txtnumero_Click(object sender, EventArgs e)
        {
            txtnumero.ForeColor = Color.Black;
            txtnumero.Clear();
            this.Size = new Size(370, 221);
            lbldifference.Visible = false;
            txtdifference.Visible = false;
            txtdifference.Clear();
        }









        private void btneffetuer_Click(object sender, EventArgs e)
        {
            if (txtmontant.Text.Equals(""))
            {
                MessageBox.Show("Entrer le montant à rembourser!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                ////////////////
                if (du > parmois)
                {
                    if (float.Parse(txtmontant.Text) < parmois)
                    {

                        MessageBox.Show("Le montant doit etre superieur ou egal à: " + parmois, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        
                    }
                    else
                    {


                        DialogResult choix = MessageBox.Show("Voulez-vous effectuer le remboursement?", "Message de confirmation", MessageBoxButtons.YesNoCancel);
                        if (choix.Equals(DialogResult.Yes))
                        {
                            if (enmois >= 0 && penalite >= 0)
                            {


                                String d2 = System.DateTime.Now.ToShortDateString();
                            }

                            string utilisateur = fenConnection.nomutilisateur;
                            bool pr = P.RechercherPretarembourser(txtnumero.Text);

                            //float apayer=  pret.RechercherKobpeye(txtnumero.Text);
                            //MessageBox.Show("" + apayer);

                            string numero = P.RecupererNumeroCompte();
                            string numcli = P.RecupererNumeroClient();
                            float montant = P.RecupererMontant();
                            string devise = P.RecupererDevise();
                            string datp = P.RecupererDatepret();
                            DateTime datr = P.RecupererDateremise();
                            string d = datr.ToShortDateString();

                            //MessageBox.Show(""+pr.getmontant());
                            //declaration date actuelle, conversion en chaine
                            float restemontant = montant - float.Parse(txtmontant.Text);
                            float totalremb = total;

                            if (restemontant <= 0)
                            {
                                if (restemontant < 0)
                                {
                                    if ((penalite > 0) && (total > 0))
                                    {
                                        float val = float.Parse(txtmontant.Text) - total;
                                        //MessageBox.Show(""+val);
                                        lbldifference.Visible = true;
                                        txtdifference.Visible = true;
                                        lbldifference.Text = "Monnaie";
                                        txtdifference.Text = "" + val;

                                    }
                                    else
                                    {
                                        float val = float.Parse(txtmontant.Text) - montant;
                                        //MessageBox.Show(""+val);
                                        lbldifference.Visible = true;
                                        txtdifference.Visible = true;
                                        lbldifference.Text = "Monnaie";
                                        txtdifference.Text = "" + val;
                                        penalite = 0;
                                        total = 0;
                                    }

                                }

                                P.effacerPret(numero);
                                P.effacerPretarembourser(numero);
                                P.effacerParmois(numero);
                                fini = 1;
                                //pret.effacerKobpeye(numero);
                                //d = datp;

                                //convertir date actuelle en tableau
                                string[] td = d.Split('/');


                                string d1 = datr.ToShortDateString();

                                //convertir date actuelle en tableau
                                string[] td1 = d1.Split('/');
                                string d24 = System.DateTime.Now.ToShortDateString();
                            }
                            else
                            {
                                if ((penalite > 0) && (total > 0))
                                {
                                    lbldifference.Visible = true;
                                    txtdifference.Visible = true;
                                    lbldifference.Text = "Balance";
                                    //float mont=float.Parse(txtmontant.Text);                            
                                    txtdifference.Text = "" + (total - (float.Parse(txtmontant.Text)));
                                }
                                else
                                {
                                    lbldifference.Visible = true;
                                    txtdifference.Visible = true;
                                    lbldifference.Text = "Balance";
                                    //float mont=float.Parse(txtmontant.Text);

                                    txtdifference.Text = "" + (montant - (float.Parse(txtmontant.Text)));
                                    //total = 0;
                                    //penalite = 0;
                                }
                                int test = 0;
                                test = P.Modifierpret(numero, restemontant);

                                if (test != 0)
                                {
                                    //MessageBox.Show("Diminution an fet!");

                                }
                                else
                                {
                                    MessageBox.Show("Diminution an pa fet!");
                                }
                            }
                            String de = System.DateTime.Now.ToShortDateString();
                            //convertir date actuelle en tableau
                            string[] tde = de.Split('/');
                            if (fini != 0)
                            {
                                MessageBox.Show("Vous avez acquitté votre pret\nMerci!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                fini = 1;
                            }
                            else
                            {
                                MessageBox.Show("Le client a reduit le montant de son pret \nMerci!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                fini = 0;
                            }
                            if (float.Parse(txtmontant.Text) <= dwe)
                            {
                                P.indexe(numero, float.Parse(txtmontant.Text), devise, datp, d, utilisateur);
                        
                                P.EnregistrerTransaction(numero, "Remboursement", float.Parse(txtmontant.Text), DateTime.Parse(de), fenConnection.nomutilisateur);

                            }
                            else
                            {
                              

                                P.indexe(numero, dwe, devise, datp, d, utilisateur);
                                P.EnregistrerTransaction(numero, "Remboursement", dwe, DateTime.Parse(de), fenConnection.nomutilisateur);


                            }



                            //formater date en format mysql (date-mois-jour)
                            //string datsys = string.Format("{0}-{1}-{2}", tde[2], tde[1], tde[0]);
                            objetutilisateur.RetracerOperation(fenConnection.nomutilisateur, "Remboursement",fenConnection.adressemac());
                            txtmontant.Clear();
                            txtnumero.Clear();
                            lblinfo.ResetText();
                            lbpenalite.ResetText();
                            this.Size = new Size(370, 221);
                            txtnumero.Focus();
                            txtnumero.Select();


                        }
                        else if (choix.Equals(DialogResult.No))
                        {

                            txtnumero.Clear();
                            txtmontant.Clear();

                        }
                    }
                }
                else
                {
                    //goto Actio;

                    if (float.Parse(txtmontant.Text) < du)
                    {

                        MessageBox.Show("Le montant doit etre superieur ou egal à: " + du, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        DialogResult choix = MessageBox.Show("Voulez-vous effectuer le remboursement?", "Message de confirmation", MessageBoxButtons.YesNoCancel);
                        if (choix.Equals(DialogResult.Yes))
                        {
                            if (enmois >= 0 && penalite >= 0)
                            {


                                String d2 = System.DateTime.Now.ToShortDateString();
                            }

                            string utilisateur = fenConnection.nomutilisateur;
                            bool pr = P.RechercherPretarembourser(txtnumero.Text);

                            //float apayer=  pret.RechercherKobpeye(txtnumero.Text);
                            //MessageBox.Show("" + apayer);

                            string numero = P.RecupererNumeroCompte();
                            string numcli = P.RecupererNumeroClient();
                            float montant = P.RecupererMontant();
                            string devise = P.RecupererDevise();
                            string datp = P.RecupererDatepret();
                            DateTime datr = P.RecupererDateremise();
                            string d = datr.ToShortDateString();

                            //MessageBox.Show(""+pr.getmontant());
                            //declaration date actuelle, conversion en chaine
                            float restemontant = montant - float.Parse(txtmontant.Text);
                            float totalremb = total;

                            if (restemontant <= 0)
                            {
                                if (restemontant < 0)
                                {
                                    if ((penalite > 0) && (total > 0))
                                    {
                                        float val = float.Parse(txtmontant.Text) - total;
                                        //MessageBox.Show(""+val);
                                        lbldifference.Visible = true;
                                        txtdifference.Visible = true;
                                        lbldifference.Text = "Monnaie";
                                        txtdifference.Text = "" + val;

                                    }
                                    else
                                    {
                                        float val = float.Parse(txtmontant.Text) - montant;
                                        //MessageBox.Show(""+val);
                                        lbldifference.Visible = true;
                                        txtdifference.Visible = true;
                                        lbldifference.Text = "Monnaie";
                                        txtdifference.Text = "" + val;
                                        penalite = 0;
                                        total = 0;
                                    }

                                }

                                P.effacerPret(numero);
                                P.effacerPretarembourser(numero);
                                P.effacerParmois(numero);
                                fini = 1;
                                //pret.effacerKobpeye(numero);
                                //d = datp;

                                //convertir date actuelle en tableau
                                string[] td = d.Split('/');


                                string d1 = datr.ToShortDateString();

                                //convertir date actuelle en tableau
                                string[] td1 = d1.Split('/');
                                string d24 = System.DateTime.Now.ToShortDateString();
                            }
                            else
                            {
                                if ((penalite > 0) && (total > 0))
                                {
                                    lbldifference.Visible = true;
                                    txtdifference.Visible = true;
                                    lbldifference.Text = "Balance";
                                    //float mont=float.Parse(txtmontant.Text);                            
                                    txtdifference.Text = "" + (total - (float.Parse(txtmontant.Text)));
                                }
                                else
                                {
                                    lbldifference.Visible = true;
                                    txtdifference.Visible = true;
                                    lbldifference.Text = "Balance";
                                    //float mont=float.Parse(txtmontant.Text);

                                    txtdifference.Text = "" + (montant - (float.Parse(txtmontant.Text)));
                                    //total = 0;
                                    //penalite = 0;
                                }
                                int test = 0;
                                test = P.Modifierpret(numero, restemontant);

                                if (test != 0)
                                {
                                    //MessageBox.Show("Diminution an fet!");

                                }
                                else
                                {
                                    MessageBox.Show("Diminution an pa fet!");
                                }
                            }
                            String de = System.DateTime.Now.ToShortDateString();
                            //convertir date actuelle en tableau
                            string[] tde = de.Split('/');
                            if (fini != 0)
                            {
                                MessageBox.Show("Vous avez acquitté votre pret\nMerci!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                fini = 1;
                            }
                            else
                            {
                                MessageBox.Show("Le client a reduit le montant de son pret \nMerci!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                fini = 0;
                            }
                            if (float.Parse(txtmontant.Text) <= dwe)
                            {
                                P.indexe(numero, float.Parse(txtmontant.Text), devise, datp, d, utilisateur);
                                P.EnregistrerTransaction(numero, "Remboursement", float.Parse(txtmontant.Text), DateTime.Parse(de), fenConnection.nomutilisateur);

                            }
                            else
                            {
                                P.indexe(numero, dwe, devise, datp, d, utilisateur);
                                P.EnregistrerTransaction(numero, "Remboursement", dwe, DateTime.Parse(de), fenConnection.nomutilisateur);


                            }



                            //formater date en format mysql (date-mois-jour)
                            //string datsys = string.Format("{0}-{1}-{2}", tde[2], tde[1], tde[0]);
                            objetutilisateur.RetracerOperation(fenConnection.nomutilisateur, "Remboursement",fenConnection.adressemac() );
                            txtmontant.Clear();
                            txtnumero.Clear();
                            lblinfo.ResetText();
                            lbpenalite.ResetText();
                            this.Size = new Size(370, 221);
                            txtnumero.Focus();
                            txtnumero.Select();


                        }
                        else if (choix.Equals(DialogResult.No))
                        {

                            txtnumero.Clear();
                            txtmontant.Clear();

                        }

                    }
                }
            }
        }
        














        private void txtnumero_TextChanged(object sender, EventArgs e)
        {
            lbldifference.Visible = false;
            txtdifference.Visible = false;
          
        }

        private void txtmontant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString().ToUpper(), @"[^0-9/.]"))
            {
                e.Handled = true;
            }
            else { e.Handled = false; }
            if (e.KeyChar == (char)8) { e.Handled = false; }
        }

        private void txtmontant_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void txtdifference_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}