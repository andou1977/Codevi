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
    public partial class fenlistertracabilitecritere : Form
    {
        public fenlistertracabilitecritere()
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
                string requet = "select * from tracabilite where numero_operation='" + parame + "'or nom_utilisateur='" + parame + "'or operations='" + parame + "'or date_operation='" + parame + "'or heure_operation='" + parame + "'or pc_operation='" + parame + "'";
        

                string chaine = "Server=localhost;Database=gestion_codevi;Uid=root;Pwd=";
                MySqlCommand cmd = null; ;
                MySqlConnection con = null;
                //MySqlDataReader rs = null;
                dgvliste.ClearSelection();
                dgvliste.Refresh();

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
                    //if (b == null)
                    //{
                    //    MessageBox.Show("Aucune tracabilite ne correspond a votre critere!");
                    //}
                    //else
                    //{
                        ad.Fill(ds, "tracabilite");
                        con.Close();
                        dgvliste.DataSource = ds.Tables["tracabilite"];
                        dgvliste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        dgvliste.AutoGenerateColumns = true;

                    //}
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

        private void txtcritere_Click(object sender, EventArgs e)
        {
            txtcritere.ForeColor = Color.Black;
            txtcritere.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtcritere_TextChanged(object sender, EventArgs e)
        {
            dgvliste.Columns.Clear();
        }

        private void fenlistertracabilitecritere_Load(object sender, EventArgs e)
        {
            txtcritere.Focus();
            txtcritere.Select();
        }
    }
}
