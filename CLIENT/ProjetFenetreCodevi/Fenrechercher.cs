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
    public partial class Fenrechercher : Form
    {
        public TcpChannel tcp = null;
        public InterfaceCompte objetcompte = null;
        public Fenrechercher()
        {
            tcp = new TcpChannel();
            objetcompte = (InterfaceCompte)Activator.GetObject(typeof(InterfaceCompte), "tcp://localhost:6060/objetcompte");
            InitializeComponent();
        }

        private void Fenrechercher_Load(object sender, EventArgs e)
        {
            txtcodecompte.Focus();
            this.Size = new Size(423,192);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int validite = 0;
            if(txtcodecompte.Text.Equals("")){

                validite = 1;
                txtcodecompte.Text = "Remplissez le champ";
                MessageBox.Show ("Entrez le numero du compte a rechercher","Attention",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                try
                {

                  bool  cl = objetcompte.RechercherCompte(txtcodecompte.Text);
                    if (!cl.Equals(false))
                       
                    {
                        
                        this.Size = new Size(429,415);
                        txtcodeclient.Text = objetcompte.RecupererNumeroClient();
                        txtmontant.Text = objetcompte.RecupererSolde().ToString();
                        txttype.Text = objetcompte.RecupererType();
                        txtdevise.Text = objetcompte.RecupererDevise();
                        txtdatecreation.Text = objetcompte.RecupererDatecreation();
                        txtetat.Text = objetcompte.RecupererEtat();
                       
                    }


                }
                catch (Exception  )
                {


                    MessageBox.Show("Ce compte n'existe pas", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
        }

        private void txtcodecompte_Click(object sender, EventArgs e)
        {
            if (txtcodecompte.Text == "Remplissez le champ")
            {
                this.Size = new Size(423, 192);
                txtcodecompte.Text = "";
            }
        }
       

        private void txtcodecompte_ModifiedChanged(object sender, EventArgs e)
        {

            txtcodeclient.Text = "";
            txtmontant.Text = "";
            txtdevise.Text = "";
            txtdatecreation.Text = "";
            txtetat.Text = "";
            txtcodecompte.Text = "";

            this.Size = new Size(423, 192);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtcodecompte_TextChanged(object sender, EventArgs e)
        {
            this.Size = new Size(423, 192);
            //txtcodecompte.Text = "";
        }

       
    }
}
