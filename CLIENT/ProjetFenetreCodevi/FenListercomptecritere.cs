
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
    public partial class FenListercomptecritere : Form
    {
        public FenListercomptecritere()
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
                try
                {
                    string para = txtcritere.Text;

                    //List<Compte> la = null;
                    //la = CompteControleur.TousComptec(para);
                    //if (la.Count == 0)

                    {
                        dgvliste.Columns.Clear();
                        MessageBox.Show("Aucun compte ne correspond a votre critere de recherche!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txtcritere_Click(object sender, EventArgs e)
        {
            txtcritere.Clear();
            txtcritere.ForeColor = Color.Black;
        }

        private void FenListercomptecritere_Load(object sender, EventArgs e)
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
