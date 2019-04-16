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
    public partial class Fenpret : Form
    {
        public TcpChannel tcp = null;
        public InterfaceCompte objetcompte = null;
        public InterfacePret objetpret = null;

        public static float montantcompte=0;
        public Fenpret()
        {
            tcp = new TcpChannel();
            objetcompte = (InterfaceCompte)Activator.GetObject(typeof(InterfaceCompte), "tcp://localhost:6060/objetcompte");
            objetpret = (InterfacePret)Activator.GetObject(typeof(InterfacePret), "tcp://localhost:6060/objetpret");

            InitializeComponent();
        }

        private void lbsolde_Click(object sender, EventArgs e)
        {

        }

        private void Fenpret_Load(object sender, EventArgs e)
        {
            this.Size = new Size(486, 186);
            txtcodecompte.Focus();
            //lbdevise.Visible = false;
            //lbdevise1.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int validite = 0;
            string bloquage = "";

           

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
                   bool    cl = objetcompte.RechercherCompte(txtcodecompte.Text);
                    bool cp2 = objetpret.RechercherClient(objetcompte.RecupererNumeroClient());

                    if (cp2 != null)
                    {

                        MessageBox.Show(" Le pret ne peut être effectué car le client a déjà un pret en cours. ", "Impossible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        validite = 1;
                        this.Size = new Size(486, 186);
                        txtcodecompte.Focus();
                        //lbdevise.Visible = false;
                        //lbdevise1.Visible = false;
                    }
                    else
                    {
                        bool cl1 = objetcompte.RechercherCompte(txtcodecompte.Text);
                        bloquage = objetcompte.RecupererEtat();

                        if (!cl.Equals(null))
                        {

                            if (bloquage.Equals("desactiver"))
                            {
                                MessageBox.Show("Ce compte est  inactif", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            else
                            {
                                //lbdevise.Visible = true;
                                //lbdevise.Text = cl.getdevise();
                                //lbdevise1.Visible = true;
                                //lbdevise1.Text = cl.getdevise();
                                txtsolde.Text = objetcompte.RecupererSolde().ToString();
                                txtdevise.Text = objetcompte.RecupererDevise().ToString();
                                this.Size = new Size(486, 412);
                                txtmontant.Focus();
                                montantcompte = objetcompte.RecupererSolde();
                            }

                        }

                    }
                }
                catch (Exception)
                {


                    MessageBox.Show("Ce compte n'existe pas", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Size = new Size(486, 186);
                    txtcodecompte.Focus();
                    //lbdevise.Visible = false;
                    //lbdevise1.Visible = false;
                }


            }
        }

        private void bteffectuer_Click(object sender, EventArgs e)
        {

            int validite = 0;
            try
            {
                if (txtmontant.Text.Equals(""))
                {

                    MessageBox.Show("Le champ montant est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    validite = 1;

                }
                else if (float.Parse(txtmontant.Text) <( (montantcompte*25)/100))
                {

                    validite = 1;

                    MessageBox.Show("La valeur du prêt ne doit pas être inferieur à 25% du montant du compte", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            catch
            {

                MessageBox.Show("Le champ montant doit avoir uniquement des valeurs numeriques", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                validite = 1;
            }

          


            //try
            //{
            //    if (txtmois.Text.Equals(""))
            //    {

            //        MessageBox.Show("Entrer le Nombre de mois", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        validite = 1;

            //    }
            //    else if (int.Parse(txtmois.Text) <= 0)
            //    {

            //        validite = 1;

            //        MessageBox.Show("Le nombre de mois ne doit pas être inferieur ou egal a 0", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //    else if (int.Parse(txtmois.Text) > 60)
            //    {

            //        validite = 1;

            //        MessageBox.Show("Le nombre de mois ne doit pas être superieur à 60\nla cooperative n'autorise pas les prets depassants 5 ans", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //}

            //catch
            //{

            //    MessageBox.Show("Le nombre de mois doit avoir uniquement des valeurs numeriques", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //    validite = 1;
            //}











            try
            {
                double pourcent;
               bool cl = objetcompte.RechercherCompte(txtcodecompte.Text);
               float sol = objetcompte.RecupererSolde();
               
                    pourcent = double.Parse(txtmontant.Text) * (0.15);
                    if (sol < pourcent)
                    {
                        MessageBox.Show("Le solde du compte est trop faible pour effectuer le pret.","Impossible",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        validite = 1;
                    }

                    if (validite != 1) {
                        try
                        {

                            if (txttaux.Text.Equals(""))
                            {

                                MessageBox.Show("Entrer l'interet", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                validite = 1;

                            }
                            else if (float.Parse(txttaux.Text) <= 0)
                            {

                                validite = 1;

                                MessageBox.Show("L'interet ne doit pas être inferieur ou egal a 0", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else if (float.Parse(txttaux.Text) > 15)
                            {

                                validite = 1;

                                MessageBox.Show("L'interet ne doit pas être superieur à 15%!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }

                        catch
                        {

                            MessageBox.Show("Le champ interet doit avoir uniquement des valeurs numeriques", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            validite = 1;
                        }

                    }














                   
                    /////////////////se la pouw komanse gade Petit Code Anle yo bon//////////////
                    int moispayer = 0;
                    if (float.Parse(txtmontant.Text) <= 1000) {
                        moispayer = 1;
                    }
                    else if (float.Parse(txtmontant.Text) <= 5000)
                    {
                        moispayer = 2;
                    }else if (float.Parse(txtmontant.Text) <= 10000)
                    {
                        moispayer = 3;
                    } else if (float.Parse(txtmontant.Text) <= 25000)
                    {
                        moispayer = 4;

                    }
                    else if (float.Parse(txtmontant.Text) <= 50000)
                    {
                        moispayer = 5;

                    }
                    else if (float.Parse(txtmontant.Text) <= 100000)
                    {
                        moispayer = 6;

                    }
                    else if (float.Parse(txtmontant.Text) <= 500000)
                    {
                        moispayer = 8;
                    }
                    else
                    {
                        moispayer = 12;

                    }
                    //DateTime calcul = System.DateTime.Now.AddDays(txtxmois * 30);
                    DateTime calcul = System.DateTime.Now.AddDays(moispayer*30);
                    string dat = calcul.ToShortDateString();

                    //MessageBox.Show("le nombre de mois est: "+moispayer+" "+ dat);           

                   
                    DateTime dat1 = System.DateTime.Now.Date;

                    DateTime dat2 = DateTime.Parse(dat);
                    string datbon = dat2.Date.ToShortDateString();
                    //MessageBox.Show(datbon);
                    if (validite != 1)
                    {
                        int comparaison = DateTime.Compare(dat1.Date, DateTime.Parse(datbon));

                        if (comparaison == 0)
                        {
                            MessageBox.Show("La date de remise ne doit pas être égale à la date actuelle.", "Impossible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            validite = 1;
                        }
                        else if (comparaison > 0)
                        {
                            MessageBox.Show("La date de remise ne doit pas être antérieure à la date actuelle.", "Impossible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            validite = 1;
                        }

                    }

                    bool cp3 = objetcompte.RechercherCompte(objetcompte.RecupererNumeroCompte());
                    
                    if (validite != 1)
                    {
                        float a = float.Parse(txtmontant.Text);
                        string ag = null;
                        TimeSpan differencedate = DateTime.Parse(datbon) - dat1.Date;
                        //MessageBox.Show(differencedate.Days+"");
                        //MessageBox.Show(differencedate.Days/30+"");
                        int jours = differencedate.Days;
                        float jourenReel = jours / 30;
                        //MessageBox.Show(jourenReel+"");
                        float pource = float.Parse(txttaux.Text);
                        double interet = pource / 100;
                        float arembourser = (float.Parse(txtmontant.Text) * (jourenReel *pource / 100)) + float.Parse(txtmontant.Text);
                        //MessageBox.Show(arembourser.ToString());

                        float mois = jourenReel;
                        float repartikob = arembourser / jourenReel;

                        //MessageBox.Show("" + repartikob);
                        DialogResult choix = MessageBox.Show("Nombre de mois:  " + moispayer + "\nDate de Remise: " + dat + "\nMontant à payer:  " + arembourser + " " + objetcompte.RecupererDevise() + "\nMontant de paie mensuel:  " + repartikob + " " + objetcompte.RecupererDevise() + "\n\nVoulez-vous effectuer le pret?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                        if(choix.Equals(DialogResult.Yes)){
                            ag = objetpret.Pret(txtcodecompte.Text, objetcompte.RecupererNumeroClient(), a, txtdevise.Text, dat1.ToShortDateString(), datbon);

                            objetpret.PretPourRemboursement(txtcodecompte.Text, objetcompte.RecupererNumeroClient(), arembourser, txtdevise.Text, dat1.ToShortDateString(), datbon);
                        objetpret.parmois(txtcodecompte.Text, arembourser);
                            //co.enregistrerKobpeye(txtcodecompte.Text, arembourser);
                            if (ag == null)
                        {

                            MessageBox.Show("Pret non effectué", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {

                            MessageBox.Show("Pret effectué avec succès!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Size = new Size(486, 186);
                            txtcodecompte.Focus();
                            txtcodecompte.Clear();
                            //lbdevise.Visible = false;
                            //lbdevise1.Visible = false;

                        }


                        }
                        else if (choix.Equals(DialogResult.No)) {
                            this.Close();
                        }
                }
            }
            //}
            catch (Exception) { }
        
        }

        private void txtcodecompte_Click(object sender, EventArgs e)
        {
            if (txtcodecompte.Text.Equals("Remplissez le champ"))
            {

                txtcodecompte.Text = "";
            }
        }

        private void btannuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtcodecompte_TextChanged(object sender, EventArgs e)
        {
            this.Size = new Size(486, 186);
            txtmontant.Clear();
            txttaux.Clear();

        }

    }
}
