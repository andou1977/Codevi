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
    public partial class FenRechercherClient : Form
    {
        public TcpChannel tcp = null;
        public InterfaceClient objetclient = null;
        public FenRechercherClient()
        {
            tcp = new TcpChannel();
            objetclient = (InterfaceClient)Activator.GetObject(typeof(InterfaceClient), "tcp://localhost:6060/objetclient");
            InitializeComponent();
        }

        private void btrechercher_Click(object sender, EventArgs e)
        {
            if (txtid.Text.Equals(""))
            {
                txtid.ForeColor = Color.Red;
                txtid.Text = "Entrer le code du client";
            }
            else {
                try
                {

                   bool cl= objetclient.Rechercherclient(txtid.Text);
                   if (!cl.Equals(null))
                 {
                     this.Size = new Size(363, 490);
                       txtnom.Text = objetclient.RecupererNom();
                       txtprenom.Text = objetclient.RecupererPrenom();
                       txtsexe.Text = objetclient.RecupererSexe();
                       rtbadresse.Text = objetclient.RecupererAdresses();
                       txttelephone.Text = objetclient.RecupererTelephone();
                       txtcin.Text = objetclient.RecupererCin();
                   }
                }
                catch (Exception ) {
                    MessageBox.Show("Client inexistant", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

               
            }
        }

        private void txtid_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txtid.ForeColor = Color.Black;
            
            txtnom.Clear();
            txtprenom.Clear();
            txtsexe.Clear();
            rtbadresse.Clear();
            txtcin.Clear();
            txttelephone.Clear();
            this.Size = new Size(363, 208);
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {
            txtid.ForeColor = Color.Black;

            txtnom.Clear();
            txtprenom.Clear();
            txtsexe.Clear();
            rtbadresse.Clear();
            txtcin.Clear();
            txttelephone.Clear();
            this.Size = new Size(363, 208);
        }

        private void FenRechercherClient_Load(object sender, EventArgs e)
        {
            //363 113
            this.Size = new Size(363, 208);
            txtid.Focus();
        }

        private void btannuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
