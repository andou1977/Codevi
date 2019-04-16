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


namespace ProjetFenetreCodevi
{
    public partial class Fenlisterpretcritere : Form
    {
        public Fenlisterpretcritere()
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
                try
                {
                    dgvliste.Columns.Clear();

                    string parame = txtcritere.Text;
                    //List<Pret> la = null;
                    //la = PretControleur.TouspretCritere(parame);
                    //if (la.Count == 0)
                    {
                        MessageBox.Show("Aucun Pret ne correspond a votre critere!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //dgvliste.ClearSelection();
                    }
                    //else
                    {
                        dgvliste.Refresh();
                        dgvliste.Columns.Clear();
                        dgvliste.Columns.Add("Numero Compte", "Numero Compte");
                        dgvliste.Columns.Add("Code Client", "Code Client");
                        dgvliste.Columns.Add("Montant", "Montant");
                        dgvliste.Columns.Add("A payer", "A payer");
                        dgvliste.Columns.Add("Devise", "Devise");
                        dgvliste.Columns.Add("Date_pret", "Date_pret");
                        dgvliste.Columns.Add("Date_remise", "Date_remise");

                        //foreach (Pret cl in la)
                        {
                            //Pret p = PretControleur.RechercherPretarembourser(cl.getNumero());


                            //string[] row = { cl.getNumero(), cl.getNumeroclient(), "" + cl.getmontant(), p.getmontant().ToString(), cl.getDevise(), cl.getDatepret(), "" + cl.getDatremiset().ToShortDateString() };
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

        private void txtcritere_Click(object sender, EventArgs e)
        {
            txtcritere.ForeColor = Color.Black;
            txtcritere.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
