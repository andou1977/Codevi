
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
    public partial class FenListercompte : Form
    {
        public FenListercompte()
        {
            InitializeComponent();
        }

        private void btnlister_Click(object sender, EventArgs e)
        {
            //try
            //{

            //    List<compte> la = null;
            //    la = compte.Touscompte();
            //    if (la.Count == 0)
            //    {
            //        MessageBox.Show("Il n'existe aucun compte!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //    else
            //    {
            //        dgvliste.Refresh();
            //        dgvliste.Columns.Clear();
            //        dgvliste.Columns.Add("Numero", "Numero");
            //        dgvliste.Columns.Add("Code Client", "Code Client");
            //        dgvliste.Columns.Add("Devise", "Devise");
            //        dgvliste.Columns.Add("Type", "Type");
            //        dgvliste.Columns.Add("Montant", "Montant");
            //        dgvliste.Columns.Add("Date", "Date");
            //        dgvliste.Columns.Add("Etat", "Etat");
            //        foreach (compte cl in la)
            //        {
            //            string[] row = { cl.getcodecompte(), cl.getcodeclient(), cl.getdevise(), cl.gettype(), "" + cl.getsolde(), cl.getdatecreation(), cl.getetat() };
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

        private void FenListercompte_Load(object sender, EventArgs e)
        {
            try
            {

                //List<Compte> la = null;
                //la = CompteControleur.TousCompte();
                //if (la.Count == 0)
                {
                    MessageBox.Show("Il n'existe aucun compte!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();

                }
                //else
                {
                    dgvliste.Refresh();
                    dgvliste.Columns.Clear();
                    dgvliste.Columns.Add("Numero", "Numero");
                    dgvliste.Columns.Add("Code Client", "Code Client");
                    dgvliste.Columns.Add("Devise", "Devise");
                    dgvliste.Columns.Add("Type", "Type");
                    dgvliste.Columns.Add("Montant", "Montant");
                    dgvliste.Columns.Add("Date", "Date");
                    dgvliste.Columns.Add("Etat", "Etat");
                    //foreach (Compte cl in la)
                    {
                        //string[] row = { cl.getcodecompte(), cl.getcodeclient(), cl.getdevise(), cl.gettype(), "" + cl.getsolde(), cl.getdatecreation(), cl.getetat() };
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
