using ProjetFenetreCodevi;
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
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Channels.Tcp;
using Com.ProjetCodevi.Interface;



namespace ProjetFenetreCodevi
{
    
    public partial class fenConnection : Form
    {
        public TcpChannel tcp = null;
        public InterfaceUtilisateur Ut = null;
        
        public fenConnection()
        {
            tcp = new TcpChannel();
            //ChannelServices.RegisterChannel(tcp);

            Ut = (InterfaceUtilisateur)Activator.GetObject(typeof(InterfaceUtilisateur), "tcp://localhost:6060/objetutilisateur");
            InitializeComponent();
        }

        public static string codeuser;
        public static string datesysteme;
        public static string pseudouser;
        public static string password;
        public static string nomutilisateur;
        public static string prenomutilisateur;
        public static string etat;

        public static string droitdacces;
        public static string adressemac()
        {
            IPGlobalProperties computerProperties = IPGlobalProperties.GetIPGlobalProperties();
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            //NetworkInterface adapter;
            NetworkInterface adapter = nics[0];
            IPInterfaceProperties properties = adapter.GetIPProperties();
            string mac = adapter.GetPhysicalAddress().ToString();

            return mac;
        }

        //public static string retracerOperation(string nomutilisateur, string operation)
        //{
           
        //    String heu = System.DateTime.Now.ToShortTimeString();
           
        //    string pc = adressemac();
        //    //formater date en format c#

            
        //    string req = "insert into tracabilite(nom_utilisateur,operations,date_operation,heure_operation,pc_operation) values ('" + nomutilisateur + "','" + operation + "','" + DateTime.Now.ToShortDateString() + "','" + heu + "','" + pc + "')";
        //    string chcon = "Server=localhost;Database=gestion_codevi;Uid=root;Pwd=";
        //    MySqlConnection con = null;
        //    MySqlCommand cmd = null;
        //    int rs;
        //    string mesaj = "";

        //    try
        //    {
        //        con = new MySqlConnection(chcon);
        //        con.Open();
        //        cmd = new MySqlCommand(req, con);
        //        rs = cmd.ExecuteNonQuery();


        //        if (rs > 0)
        //        {
        //            //Console.WriteLine("------------------------------");
        //            //mesaj = ("tracabilite enregistree !");


        //        }
        //        else
        //        {
        //            //Console.WriteLine("------------------------------");
        //            //mesaj = ("tracabilite non enregistree !");

        //        }



        //    }
        //    catch (MySqlException se)
        //    {

        //        mesaj = se.Message;

        //    }
        //    finally
        //    {
        //        if (con != null)
        //        {
        //            con.Close();
        //        }
        //    }
        //    return mesaj;

        //}

        private void lblusername_Click(object sender, EventArgs e)
        {

        }



        private void btnconnexion_Click(object sender, EventArgs e)    {
            

           
            
            if (txtusername.Text.Equals(""))
            { 
                
               
                MessageBox.Show( " Entrer votre pseudo ","Erreur", MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtusername.Focus();
            }
            else if (txtpassword.Text.Equals(""))
            {

                MessageBox.Show("Entrer votre mot de passe", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpassword.Focus();
            }
            else
            {
                try
                {
                   
                  bool  ut = Ut.connexion(txtusername.Text, txtpassword.Text);
               
                    if (ut != false)
                    {
                        string caissier = "caissier";
                        string gestionnaire = "gestionnaire";
                        string administrateur = "administrateur";
                        string etatactif = "activer"; string actif = "Activer";
                        string etatinactif = "desactiver"; string desactiver = "Desactiver";
                        if (Ut.RecupererEtat().Equals(etatactif) || Ut.RecupererEtat().Equals(actif))
                        {

                            nomutilisateur = Ut.RecupererNom();
                            prenomutilisateur = Ut.RecupererPrenom();
                            if (Ut.RecupererDroitdacces().Equals(caissier))
                            {
                                etat = Ut.RecupererDroitdacces();

                                droitdacces = Ut.RecupererDroitdacces();
                                codeuser = Ut.RecupererCode();
                                pseudouser = Ut.RecupererPseudo();
                                password = Ut.RecupererMotdepasse();
                                ///////////////////////////////////
                                this.Hide();
                                //MessageBox.Show("c'est un caissier");
                                FenPrincipal fp = new FenPrincipal();
                                this.Hide();
                                var FenPrincipal = new FenPrincipal();
                                FenPrincipal.Closed += (s, args) => this.Close();
                                fp.Show();
                                fp.lblacceuil.Text = "Bienvenue Caissier";
                                fp.mclient.Enabled = true;
                                ///*///////////*/                              
                                fp.smnEnrClient.Enabled = true;
                                fp.smnRechClient.Enabled = true;
                                fp.smnModClient.Enabled = false;
                                fp.smnLisClient.Enabled = false;
                                /////*/////////////////////////////*/
                                fp.mCompte.Enabled = true;
                                fp.smnEnrCompte.Enabled =false;
                                fp.smnRechCompte.Enabled = true;
                                fp.smnLisCompte.Enabled = false;
                                fp.bloquerToolStripMenuItem1.Enabled = false;
                                fp.debloquerToolStripMenuItem1.Enabled = false;
                                ///*///////////////////////*/
                                fp.mpret.Enabled = true;
                                fp.smnenrpret.Enabled = false;
                                fp.smnrecherchpret.Enabled = true;
                                //fp.smnmodifierpret.Enabled = true;
                                fp.smnlisterpret.Enabled = false;
                                
                                //// /*//////////////////////////*/
                                fp.mtransaction.Enabled = true;
                                fp.smndepot.Enabled=true;
                                fp.smnretrait.Enabled = true;
                                fp.smnvirement.Enabled = false;
                                fp.smnlistertransaction.Enabled = false;
                                //mnutilisateur.Enabled = false;
                                //smnajouterutilisateur.Enabled = false;
                                //smnrecherchuser.Enabled = false;
                                //smnmodifieruser.Enabled = false;
                                //smnlisterutilisateur.Enabled = false;
                                //smnlistinactifuser.Enabled = false;
                                //smnlistinactifuser.Enabled = false;
                                //smnbloquerutilisateur.Enabled = false;
                                //smndebolqueruser.Enabled = false;

                               fp.mrembourser.Enabled = true;
                               fp.smnlisterremboursement.Enabled = false;
                                
                                Ut.RetracerOperation(nomutilisateur, "Connexion",adressemac());

                            }
                            else if (Ut.RecupererDroitdacces().Equals(gestionnaire))
                            {
                                droitdacces = Ut.RecupererDroitdacces();
                                etat = Ut.RecupererEtat();

                               
                                codeuser = Ut.RecupererCode();
                                pseudouser = Ut.RecupererPseudo();
                                password = Ut.RecupererMotdepasse();
                                ///////////////////////////////////
                                this.Hide();
                                //MessageBox.Show("c'est un caissier");
                                FenPrincipal fp = new FenPrincipal();
                                this.Hide();
                                var FenPrincipal = new FenPrincipal();
                                FenPrincipal.Closed += (s, args) => this.Close();
                                fp.Show();
                                fp.lblacceuil.Text = "Bienvenue Gestionnaire";

                                fp.mclient.Enabled = true;
                                ///*///////////*/                              
                                fp.smnEnrClient.Enabled = true;
                                fp.smnRechClient.Enabled = true;
                                fp.smnModClient.Enabled = true;
                                fp.smnLisClient.Enabled = true;
                                /////*/////////////////////////////*/
                                fp.mCompte.Enabled = true;
                                fp.smnEnrCompte.Enabled = true;
                                fp.smnRechCompte.Enabled = true;
                                fp.smnLisCompte.Enabled = true;

                                fp.mrembourser.Enabled = true;
                                ///*///////////////////////*/
                                fp.mpret.Enabled = true;
                                fp.smnenrpret.Enabled = true;
                                fp.smnrecherchpret.Enabled = true;
                                //fp.smnmodifierpret.Enabled = true;
                                fp.smnlisterpret.Enabled = true;

                                //// /*//////////////////////////*/
                                fp.mtransaction.Enabled = true;
                                fp.smndepot.Enabled = true;
                                fp.smnretrait.Enabled = true;
                                fp.smnvirement.Enabled = true;
                                fp.smnlistertransaction.Enabled = true;
                                //mnutilisateur.Enabled = false;
                                //smnajouterutilisateur.Enabled = false;
                                //smnrecherchuser.Enabled = false;
                                //smnmodifieruser.Enabled = false;
                                //smnlisterutilisateur.Enabled = false;
                                //smnlistinactifuser.Enabled = false;
                                //smnlistinactifuser.Enabled = false;
                                //smnbloquerutilisateur.Enabled = false;
                                //smndebolqueruser.Enabled = false;
                                Ut.RetracerOperation(nomutilisateur, "Connexion",adressemac());

                            }
                            else if (Ut.RecupererDroitdacces().Equals(administrateur))
                            {
                               
                                //MessageBox.Show("c'est un administrateur");
                                etat = Ut.RecupererEtat();

                                droitdacces = Ut.RecupererDroitdacces();
                                codeuser = Ut.RecupererCode();
                                pseudouser = Ut.RecupererPseudo();
                                password = Ut.RecupererMotdepasse();
                                ///////////////////////////////////
                                //this.Hide();
                                //MessageBox.Show("c'est un caissier");
                                FenPrincipal fp = new FenPrincipal();
                                this.Hide();
                                var FenPrincipal = new FenPrincipal();
                                FenPrincipal.Closed += (s, args) => this.Close();
                                fp.Show();
                                fp.lblacceuil.Text = "Bienvenue Administrateur";
                                fp.mrembourser.Enabled = false;
                                //fp.mclient.Enabled = true;
                                /////*///////////*/                              
                                //fp.smnEnrClient.Enabled = true;
                                //fp.smnRechClient.Enabled = true;
                                //fp.smnModClient.Enabled = true;
                                //fp.smnLisClient.Enabled = true;
                                ///////*/////////////////////////////*/
                                //fp.mCompte.Enabled = true;
                                //fp.smnEnrCompte.Enabled = true;
                                //fp.smnRechCompte.Enabled = true;
                                //fp.smnLisCompte.Enabled = true;
                                /////*///////////////////////*/
                                //fp.mpret.Enabled = true;
                                //fp.smnenrpret.Enabled = true;
                                //fp.smnrecherchpret.Enabled = true;
                                //fp.smnmodifierpret.Enabled = true;
                                //fp.smnlisterpret.Enabled = true;

                                fp.mtransaction.Enabled = true;
                                fp.smndepot.Enabled = false;
                                fp.smnretrait.Enabled = false;
                                fp.smnvirement.Enabled = false;
                                fp.smnlistertransaction.Enabled = true;
                                //// /*//////////////////////////*/
                                fp.mnutilisateur.Enabled = true;
                                fp.smnajouterutilisateur.Enabled = true;
                                fp.smnrecherchuser.Enabled = true;
                                fp.smnmodifieruser.Enabled = true;
                                fp.smnlisterutilisateur.Enabled = true;
                                fp.smnlisteractifuser.Enabled = true;
                                fp.smnlistinactifuser.Enabled = true;
                                fp.smnbloquerutilisateur.Enabled = true;
                                fp.smndebolqueruser.Enabled = true;
                                fp.mtransaction.Enabled = true;
                                fp.mtracabilite.Enabled = true;
                                Ut.RetracerOperation(nomutilisateur, "Connexion",adressemac());

                            }

                        }
                        else if (Ut.RecupererEtat().Equals(etatinactif) || Ut.RecupererEtat().Equals(desactiver))
                        {

                            MessageBox.Show("Votre compte est bloqué, contactez l'administrateur!", "Inaccessibilite", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtpassword.Clear();
                            txtusername.Clear();
                            txtusername.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Pseudo ou mot de passe incorrect", "Inaccessibilite", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtpassword.Clear();
                        txtusername.Clear();
                        txtusername.Focus();
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                }
            }
        }

        private void txtusername_Click(object sender, EventArgs e)
        {
            txtusername.Clear();
            txtusername.ForeColor = Color.Black;
        }

        private void txtpassword_Click(object sender, EventArgs e)
        {
            txtpassword.Clear();
            txtpassword.ForeColor = Color.Black;
        }

        private void btnannuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fenConnection_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void fenConnection_Load(object sender, EventArgs e)
        {

        }

       
        
    }
}
