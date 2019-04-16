using Com.ProjetCodevi.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetFenetreCodevi
{
    public partial class FenModifierUtilisateur : Form
    {
        public TcpChannel tcp = null;
        public InterfaceUtilisateur Ut = null;
        public FenModifierUtilisateur()
        {
            tcp = new TcpChannel();
            Ut = (InterfaceUtilisateur)Activator.GetObject(typeof(InterfaceUtilisateur), "tcp://localhost:6060/objetutilisteur");
            InitializeComponent();
        }

        private void btnrechercher_Click(object sender, EventArgs e)
        {
             if (txtcode.Text.Equals(""))
            {
                MessageBox.Show("Entrer le code de l'utilisateur", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {

                   
                  bool  util = Ut.RechercherUtilisateur(txtcode.Text);
                    if (!util.Equals(false))
                    {
                        this.Size = new Size(399, 448);
                        txtnom.Enabled = false;
                        txtprenom.Enabled = false;
                        cmbdroit.Enabled = false;
                        txtpseudo.Enabled = false;
                        cmbetat.Enabled = false;
                        txtmot.Enabled = false;

                        txtnom.Text = Ut.RecupererNom();
                        txtprenom.Text = Ut.RecupererPrenom();

                        cmbdroit.Text = Ut.RecupererDroitdacces();
                        txtpseudo.Text = Ut.RecupererPseudo();
                        cmbetat.Text = Ut.RecupererEtat();
                        txtmot.Text = Ut.RecupererMotdepasse();
                        btnmodifier.Enabled = true;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Utlisateur inexistant", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
        
        }

        private void txtcode_Click(object sender, EventArgs e)
        {
            txtcode.Clear();
            txtcode.ForeColor = Color.Black;
            txtnom.Clear();
            txtprenom.Clear();
            cmbdroit.ResetText();
            cmbetat.ResetText();
            txtmot.Clear();
            txtpseudo.Clear();
            this.Size = new Size(399, 164);

        }

        private void txtcode_TextChanged(object sender, EventArgs e)
        {
            txtcode.ForeColor = Color.Black;
            txtnom.Clear();
            txtprenom.Clear();
            cmbdroit.ResetText();
            cmbetat.ResetText();
            txtmot.Clear();
            txtpseudo.Clear();
            this.Size = new Size(399, 164);

        }

        private void btnom_Click(object sender, EventArgs e)
        {
            txtnom.Enabled = true;
          
            txtnom.Focus();
            
            txtprenom.Enabled = false;
            cmbdroit.Enabled = false;
            cmbetat.Enabled = false;
            txtmot.Enabled = false;
            txtpseudo.Enabled = false;
        }

        private void btnannuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btprenom_Click(object sender, EventArgs e)
        {
            txtprenom.Enabled = true;

            txtprenom.Focus();
            txtnom.Enabled = false;
            cmbdroit.Enabled = false;
            cmbetat.Enabled = false;
            txtmot.Enabled = false;
            txtpseudo.Enabled = false;

        }

        private void btpseudo_Click(object sender, EventArgs e)
        {
            txtpseudo.Enabled = true;

            txtpseudo.Focus();
            txtnom.Enabled = false;
            txtprenom.Enabled = false;
            cmbdroit.Enabled = false;
            cmbetat.Enabled = false;
            txtmot.Enabled = false;

        }

        private void btmot_Click(object sender, EventArgs e)
        {
            txtmot.Enabled = true;

            txtmot.Focus();
            txtnom.Enabled = false;
            txtprenom.Enabled = false;
            cmbdroit.Enabled = false;
            cmbetat.Enabled = false;
            txtpseudo.Enabled = false;

        }

        private void btdroit_Click(object sender, EventArgs e)
        {
            cmbdroit.Enabled = true;

            cmbdroit.Focus();
            txtnom.Enabled = false;
            txtprenom.Enabled = false;
            cmbetat.Enabled = false;
            txtmot.Enabled = false;
            txtpseudo.Enabled = false;

        }

        private void btetat_Click(object sender, EventArgs e)
        {
            cmbetat.Enabled = true;

            cmbetat.Focus();
            txtnom.Enabled = false;
            txtprenom.Enabled = false;
            cmbdroit.Enabled = false;
            txtmot.Enabled = false;
            txtpseudo.Enabled = false;
        }

        private void FenModifierUtilisateur_Load(object sender, EventArgs e)
        {
            btnmodifier.Enabled = true;
            txtcode.Focus();
            txtcode.Select();
            this.Size = new Size(399, 164);
            txtcode.Focus();
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            if ((txtnom.Enabled == false) && (txtprenom.Enabled == false) && (txtpseudo.Enabled == false) && (txtmot.Enabled == false)
                
                &&(cmbdroit.Enabled==false)&&(cmbetat.Enabled==false))
            {

                MessageBox.Show("Aucune modification n'a été apportée!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                
               bool ut = Ut.RechercherUtilisateur(txtcode.Text);

                if (e == null)
                {
                    Console.WriteLine("Utilisateur non trouvé", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    if (txtnom.Text.Equals("") || txtprenom.Text.Equals("") || txtpseudo.Text.Equals("") || txtmot.Text.Equals(""))
                    {
                        MessageBox.Show("Aucun champ ne doit etre vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        Ut.RechercherUtilisateur(txtcode.Text);

                        string cod = txtcode.Text;
                        string nom = txtnom.Text;
                        string prenom = txtprenom.Text;
                        string ps = txtpseudo.Text;
                        string droit = cmbdroit.SelectedItem.ToString();
                        string eta = cmbetat.SelectedItem.ToString();
                        string mod = txtmot.Text;

                        // string cod = ut.Get_code();
                        // string nom = ut.Get_nom();
                        // string prenom = ut.Get_prenom();
                        // string ps = ut.Get_pseudo();
                        //string droit = ut.Get_droitacces();
                        //string eta = ut.Get_etatcompte();
                        //string mod = ut.Get_motdepasse();

                        int test = 0;
                        test = Ut.ModifierUtilisateur(cod, nom, prenom, ps, mod, droit, eta);
                        string opera = "Modifier Utilisateur";
                        if (test != 0)
                        {

                            Ut.RetracerOperation(fenConnection.nomutilisateur, opera,fenConnection.adressemac());
                            MessageBox.Show("Modification réussie!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Size = new Size(399, 164);
                            txtcode.Clear();
                            txtnom.Enabled = false;
                            txtprenom.Enabled = false;
                            cmbdroit.Enabled = false;
                            txtpseudo.Enabled = false;
                            cmbetat.Enabled = false;
                            txtmot.Enabled = false;

                          

                           
                        }
                        else { MessageBox.Show("Modification echouée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                }
            }
        }
    }
}
