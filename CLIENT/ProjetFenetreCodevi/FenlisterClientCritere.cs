using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetFenetreCodevi
{
    public partial class FenlisterClientCritere : Form
    {
        public FenlisterClientCritere()
        {
            InitializeComponent();
        }

        private void btnlister_Click(object sender, EventArgs e)
        {
                if (txtcritere.Text.Equals(""))
            {
                txtcritere.ForeColor = Color.Red;
                txtcritere.Text = "Entrer le critere de recherche";

            } else {
                txtcritere.ForeColor = Color.Black;
                try
                {
                    string para = txtcritere.Text;

                    //MessageBox.Show(para);
                    //List<Client> la = null;                      
                    //la=ClientControleur.Tousclients(para);
                    //if (la.Count()==0)
                    {
                        dgvliste.Columns.Clear();
                        MessageBox.Show("Aucune donnée ne correspond a votre critere de recherche", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    //else
                    {
                        dgvliste.Refresh();
                        dgvliste.Columns.Clear();
                        dgvliste.Columns.Add("Code", "Code");
                        dgvliste.Columns.Add("Nom", "Nom");
                        dgvliste.Columns.Add("Prenom", "Prenom");
                        dgvliste.Columns.Add("Sexe", "Sexe");
                        dgvliste.Columns.Add("Adresse", "Adresse");
                        dgvliste.Columns.Add("Telephone", "Telephone");
                        dgvliste.Columns.Add("Cin", "Cin");
                        dgvliste.Columns.Add("Email", "Email");

                        //foreach (Client cl in la)
                        {  
                            //string[] row = { cl.getnumclient(), cl.getnom(), cl.getprenom(), cl.getsexe(), cl.getadresse(), cl.gettelephone(), cl.getcin(),cl.getemail() };
                            //dgvliste.Rows.Insert(0, row);
                        }

                    }
                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }

            }
        }
        
        private void txtcritere_MouseClick(object sender, MouseEventArgs e)
        {
            txtcritere.Clear();
            txtcritere.ForeColor = Color.Black;
        }

        private void FenlisterClientCritere_Load(object sender, EventArgs e)
        {
            txtcritere.Focus();
            txtcritere.Select();
        }

        private void btnannuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
