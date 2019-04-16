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
    public partial class fenrechercherpret : Form
    {
        public TcpChannel tcp = null;
        public InterfacePret objetpret = null;
        public fenrechercherpret()
        {
            tcp = new TcpChannel();
            objetpret = (InterfacePret)Activator.GetObject(typeof(InterfacePret), "tcp://localhost:6060/objetpret");
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int validite = 0;
                if (txtcodeclient.Text.Equals(""))
                {

                    validite = 1;

                    MessageBox.Show("Remplissez le champ de recherche", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    bool cpt = objetpret.RechercherPret(txtcodeclient.Text);
                    bool p = objetpret.RechercherPretarembourser(txtcodeclient.Text);

                    if (cpt != null)
                    {

                        this.Size = new Size(404, 410);
                        txtclient.Text = objetpret.RecupererNumeroClient();
                        txtmontant.Text = objetpret.RecupererMontant().ToString();
                        txtdate.Text = objetpret.RecupererDatepret();
                        txtremise.Text = objetpret.RecupererDateremise().ToString("d");
                        txtdu.Text = objetpret.RecupererMontant().ToString();
                        txtdevise.Text = objetpret.RecupererDevise();
                    }
                    else
                    {

                        MessageBox.Show("Ce compte n'est lié à aucun pret", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            catch (Exception df) { MessageBox.Show(df.Message); }
            }
        
                        




            
        

        private void fenrechercherpret_Load(object sender, EventArgs e)
        {
            this.Size = new Size(423, 182);
            txtcodeclient.Focus();
        }

        private void txtcodeclient_Click(object sender, EventArgs e)
        {

            if (txtcodeclient.Text.Equals("Remplissez le champ"))
            {

                txtcodeclient.Text = "";
            }
        }

        private void txtcodeclient_TextChanged(object sender, EventArgs e)
        {
            this.Size = new Size(423, 182);
            txtclient.Text = "";
            txtmontant.Text = "";
            txtdate.Text = "";
            txtremise.Text = "";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}

