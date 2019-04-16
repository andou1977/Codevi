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

namespace ProjetFenetreCodevi
{
    public partial class Fenlistertransactioncritere : Form
    {
        public Fenlistertransactioncritere()
        {
            InitializeComponent();
        }

        private void btnlister_Click(object sender, EventArgs e)
        {
            if (txtcritere.Text.Equals(""))
            {
                txtcritere.ForeColor = Color.Red;
                txtcritere.Text = "Entrer le critere de recherche";

            }
            else
            {

                txtcritere.ForeColor = Color.Black;
                string parame = txtcritere.Text;
                string requet = "select * from transaction where numero='" + parame + "'or description='" + parame + "'or montant='" + parame + "'or date_transaction='" + parame + "'or utilisateur='" + parame + "'";

                dgvliste.ClearSelection();
                dgvliste.Refresh();
                string chaine = "Server=localhost;Database=gestion_codevi;Uid=root;Pwd=";
                MySqlCommand cmd = null; ;
                MySqlConnection con = null;
                //MySqlDataReader rs = null;


                try
                {

                    con = new MySqlConnection(chaine);
                    con.Open();
                    cmd = new MySqlCommand(requet, con);
                    MySqlDataAdapter ad = null;
                    ad = new MySqlDataAdapter(cmd);
                    MySqlCommandBuilder buil = null;
                    buil = new MySqlCommandBuilder(ad);
                    DataSet ds = null;
                    ds = new DataSet();
                    ad.Fill(ds, "transaction");
                    con.Close();
                    dgvliste.DataSource = ds.Tables["transaction"];
                    dgvliste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgvliste.AutoGenerateColumns = true;

                }
                catch (MySqlException sq)
                {
                    MessageBox.Show(sq.Message);

                }
                finally
                {
                    if (con != null)
                    {
                        con.Close();
                    }
                }
            }
        }

        private void txtcritere_TextChanged(object sender, EventArgs e)
        {
            dgvliste.Columns.Clear();
        }

        private void txtcritere_Click(object sender, EventArgs e)
        {
            txtcritere.Clear();
            txtcritere.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Fenlistertransactioncritere_Load(object sender, EventArgs e)
        {
            txtcritere.Select();
        }
    }
}
