using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Com.ProjetCodevi.Controleur;
//using Com.ProjetCodevi.Domaine;

namespace ProjetFenetreCodevi
{
    public partial class FenListerpret : Form
    {
        public FenListerpret()
        {
            InitializeComponent();
        }

        private void btnlister_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    dgvliste.Columns.Clear();

            //    List<pret> la = null;
            //    la = pret.TousPret();
            //    if (la.Count == 0)
            //    {
            //        MessageBox.Show("Aucun Pret n'est enregistré!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    else
            //    {
                   
            //        dgvliste.Refresh();
            //        dgvliste.Columns.Clear();
            //        dgvliste.Columns.Add("Numero Compte", "Numero Compte");
            //        dgvliste.Columns.Add("Code Client", "Code Client");
            //        dgvliste.Columns.Add("Montant", "Montant");
            //        dgvliste.Columns.Add("A payer", "A payer");
            //        dgvliste.Columns.Add("Devise", "Devise");
            //        dgvliste.Columns.Add("Date_pret", "Date_pret");
            //        dgvliste.Columns.Add("Date_remise", "Date_remise");
                   
            //        foreach (pret cl in la)
            //        {
            //            pret p = pret.RechercherPretarembourser(cl.getNumero());



            //            string[] row = { cl.getNumero(), cl.getNumeroclient(), "" + cl.getmontant(), p.getmontant().ToString(), cl.getDevise(), cl.getDatepret(), "" + cl.getDatremiset().ToShortDateString() };
            //            dgvliste.Rows.Insert(0, row);

            //        }
            //    }

            //}
            //catch (Exception ec)
            //{
            //    MessageBox.Show(ec.Message);
            //}

        }

        private void btannuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FenListerpret_Load(object sender, EventArgs e)
        {
            try
            {
                dgvliste.Columns.Clear();

                //List<Pret> la = null;
                //la = PretControleur.Touspret();
                //if (la.Count == 0)
                {
                    MessageBox.Show("Aucun Pret n'est enregistré!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

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
}
