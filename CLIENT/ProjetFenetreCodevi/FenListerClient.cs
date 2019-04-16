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
using Com.ProjetCodevi.Interface;
using System.Runtime.Remoting.Channels.Tcp;


namespace ProjetFenetreCodevi
{
    public partial class FenListerClient : Form
    {
        public static InterfaceCompte objetcompte = null;
        public static InterfaceClient objetClient = null;
        public static InterfaceUtilisateur objetUtilisateur = null;
        public static TcpChannel tcp = null;
        public FenListerClient()
        {
            tcp = new TcpChannel();
            objetcompte = (InterfaceCompte)Activator.GetObject(typeof(InterfaceCompte), "tcp://localhost:6060/objetcompte");
            objetClient = (InterfaceClient)Activator.GetObject(typeof(InterfaceClient), "tcp://localhost:6060/objetclient");
            objetUtilisateur = (InterfaceUtilisateur)Activator.GetObject(typeof(InterfaceUtilisateur), "tcp://localhost:6060/objetutilisateur");
            InitializeComponent();
        }

        private void btnlister_Click(object sender, EventArgs e)
        {
            //try
            //{

            //    List<client> la = null; 
            //        la=client.Tousclient();
            //    if(la.Count==0){
            //        MessageBox.Show("Il n'existe aucun client!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }else{
            //    dgvliste.Refresh();
            //    dgvliste.Columns.Clear();
            //    dgvliste.Columns.Add("Code", "Code");
            //    dgvliste.Columns.Add("Nom", "Nom");
            //    dgvliste.Columns.Add("Prenom", "Prenom");
            //    dgvliste.Columns.Add("Sexe", "Sexe");
            //    dgvliste.Columns.Add("Adresse", "Adresse");
            //    dgvliste.Columns.Add("Telephone", "Telephone");
            //    dgvliste.Columns.Add("Cin", "Cin");
            //    foreach (client cl in la) {
               
                   
            //        string[] row ={cl.getnumclient() ,cl.getnom(),cl.getprenom(),cl.getsexe(),cl.getadresse(),cl.gettelephone(),cl.getcin()};
            //        dgvliste.Rows.Insert(0,row);
                  
            //    }
            //    }
                           
            //}
            //catch (Exception ec) {
            //    MessageBox.Show(ec.Message);
            //}


        }

        private void dgvliste_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btannuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FenListerClient_Load(object sender, EventArgs e)
        {
            try
            {

                //List<Client> la = null;
                //la = ClientControleur.Tousclient();
                //if (la.Count == 0)
                {
                    MessageBox.Show("Il n'existe aucun client!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
