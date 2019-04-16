
using Com.ProjetCodevi.Interface;
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
    public partial class FenListerUtilisateurInactif : Form
    {
        public FenListerUtilisateurInactif()
        {
            InitializeComponent();
        }

        private void btannuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlister_Click(object sender, EventArgs e)
        {

            //try
            //{

            //    List<Utilisateur> la = null;
            //    la = Utilisateur.listerutilisateurinactif();
            //    if (la.Count == 0)
            //    {
            //        MessageBox.Show("Il n'existe aucun utilisateur inactif!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    else
            //    {
            //        dgvliste.Refresh();
            //        dgvliste.Columns.Clear();
            //        dgvliste.Columns.Add("Code", "Code");
            //        dgvliste.Columns.Add("Nom", "Nom");
            //        dgvliste.Columns.Add("Prenom", "Prenom");
            //        dgvliste.Columns.Add("Pseudo", "Pseudo");
            //        //dgvliste.Columns.Add("Password", "Password");

            //        dgvliste.Columns.Add("Droit ", "Droit");
            //        dgvliste.Columns.Add("Etat", "Etat");
            //        dgvliste.Columns.Add("Date ajout", "Date ajout");
            //        foreach (Utilisateur rs in la)
            //        {


            //            string[] row = { rs.Get_code(), rs.Get_nom(), rs.Get_prenom(), rs.Get_pseudo(),  rs.Get_droitacces(), rs.Get_etatcompte(), rs.Get_date() };
            //            dgvliste.Rows.Insert(0, row);

            //        }
            //    }

            //}
            //catch (Exception ec)
            //{
            //    MessageBox.Show(ec.Message);
            //}
        }

        private void FenListerUtilisateurInactif_Load(object sender, EventArgs e)
        {
            try
            {

                //List<Utilisateur> la = null;
                //la = UtilisateurControleur.listerutilisateurinactif();
                //if (la.Count == 0)
                {
                    MessageBox.Show("Il n'existe aucun utilisateur inactif!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
                //else
                {
                    dgvliste.Refresh();
                    dgvliste.Columns.Clear();
                    dgvliste.Columns.Add("Code", "Code");
                    dgvliste.Columns.Add("Nom", "Nom");
                    dgvliste.Columns.Add("Prenom", "Prenom");
                    dgvliste.Columns.Add("Pseudo", "Pseudo");
                    //dgvliste.Columns.Add("Password", "Password");

                    dgvliste.Columns.Add("Droit ", "Droit");
                    dgvliste.Columns.Add("Etat", "Etat");
                    dgvliste.Columns.Add("Date ajout", "Date ajout");
                    //foreach (Utilisateur rs in la)
                    {


                        //string[] row = { rs.Get_code(), rs.Get_nom(), rs.Get_prenom(), rs.Get_pseudo(), rs.Get_droitacces(), rs.Get_etatcompte(), rs.Get_date() };
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
