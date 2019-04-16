//using MySql.Data.MySqlClient;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Text.RegularExpressions;


//namespace ProjetFenetreCodevi
//{
//    class client
//    {
//        // declarations des attributs


//        private string numclient;
//        private string nom;
//        private string prenom;
//        private string sexe;
//        private string adresse;
//        private string telephone;
//        private string cin;



//        //constructeur par defaut
//        public client() { }

//        //constructeur avec parametre
//        public client(string numclient, string nom, string prenom, string sexe, string adresse, string telephone, string cin)
//        {

//            this.numclient = numclient;
//            this.nom = nom;
//            this.prenom = prenom;
//            this.sexe = sexe;
//            this.adresse = adresse;
//            this.telephone = telephone;
//            this.cin = cin;


//        }

//        // methode setteurs

//        public void setnumclient(string numclient)
//        {
//            this.numclient = numclient;

//        }

//        public void setnom(string nom)
//        {
//            this.nom = nom;
           

//        }
//        public void setprenom(string prenom)
//        {
//            this.prenom = prenom;

//        }
//        public void setsexe(string sexe)
//        {
//            this.sexe = sexe;

//        }
//        public void setadresse(string adresse)
//        {
//            this.adresse = adresse;

//        }
//        public void settelephone(string telephone)
//        {
//            this.telephone = telephone;

//        }
//        public void setcin(string cin)
//        {
//            this.cin = cin;

//        }

//        //methode getteurs
//        public string getnumclient()
//        {
//            return this.numclient;

//        }
//        public string getnom()
//        {
//            return this.nom;

//        }
//        public string getprenom()
//        {
//            return this.prenom;

//        }
//        public string getsexe()
//        {
//            return this.sexe;

//        }
//        public string getadresse()
//        {
//            return this.adresse;

//        }
//        public string gettelephone()
//        {
//            return this.telephone;

//        }

//        public string getcin()
//        {
//            return this.cin;
//        }


//        //methode supplementaire

//        //insertion d un client

//        public int insererclient()
//        {

//            int message = 0;

//            string chaine = "Server=localhost;Database=gestion_codevi;Uid=root;Pwd=";
//            MySqlCommand cmd = null; ;
//            MySqlConnection con = null;
//            int verif = 0;
//            string requet = "insert into client values('" + this.getnumclient() + "','" + this.getnom() + "','" + this.getprenom() + "','" + this.getsexe() + "','" + this.getadresse() + "','" + this.gettelephone() + "','" + this.getcin() + "')";
//            try
//            {

//                con = new MySqlConnection(chaine);
//                con.Open();
//                cmd = new MySqlCommand(requet, con);
//                verif = cmd.ExecuteNonQuery();
//                if (verif > 0)
//                {
//                    //message = "Client Enregistré";
//                    message++;

//                }
//            }
//            catch (MySqlException )
//            {
//                //message = "" + sq.Message;

//            }
//            finally
//            {
//                if (con != null)
//                {
//                    con.Close();
//                }


//            }
//            return message;
//        }

//        // rechercher client
//        public static client rechercherclient(string codeclient)
//        {
//            client et = null;


//            string chaine = "Server=localhost;Database=gestion_codevi;Uid=root;Pwd=";
//            MySqlCommand cmd = null; ;
//            MySqlConnection con = null;
//            MySqlDataReader rs = null;

//            string requet = "select * from client where code_client='" + codeclient + "'";
//            try
//            {

//                con = new MySqlConnection(chaine);
//                con.Open();
//                cmd = new MySqlCommand(requet, con);
//                rs = cmd.ExecuteReader();
//                if (rs.Read())
//                {

//                    et = new client(rs.GetString(0), rs.GetString(1), rs.GetString(2), rs.GetString(3), rs.GetString(4), rs.GetString(5), rs.GetString(6));


//                }

//            }
//            catch (MySqlException sq)
//            {
//                Console.WriteLine(sq.Message);

//            }
//            finally
//            {
//                if (con != null)
//                {
//                    con.Close();
//                }
//            }






//            return et;

//        }

//        //lister client
//        public static List<client> Tousclients(string parametre)
//        {
//            List<client> l = null; 
//                l=new List<client>();
//            string req = "select * from client where code_client='" + parametre + "' or nom='" + parametre + "'or prenom='" + parametre + "'or sexe='" + parametre + "'or adresse='" + parametre + "'or telephone='" + parametre + "'or cin='" + parametre + "' order by code_client";
//            string chaine = "Server=localhost;Database=gestion_codevi;Uid=root;Pwd=";
//            MySqlConnection con = null;
//            MySqlCommand cmd = null;
//            MySqlDataReader rs = null;
//            try
//            {
//                con = new MySqlConnection(chaine);
//                con.Open();
//                cmd = new MySqlCommand(req, con);
//                rs = cmd.ExecuteReader();
//                while (rs.Read())
//                {
//                    client p = new client(rs.GetString(0), rs.GetString(1), rs.GetString(2), rs.GetString(3), rs.GetString(4), rs.GetString(5), rs.GetString(6));
//                    l.Add(p);
//                }
//            }
//            catch (MySqlException se)
//            {
//                Console.WriteLine(se.Message);
//            }
//            finally
//            {
//                if (con != null)
//                {
//                    con.Close();
//                }
//            }

//            return l;

//        }

//        public static List<client> Tousclient()
//        {
//            List<client> l = null; 
//                l=new List<client>();
//            //new List<client>();
//            string req = "select * from client order by code_client";
//            string chaine = "Server=localhost;Database=gestion_codevi;Uid=root;Pwd=";
//            MySqlConnection con = null;
//            MySqlCommand cmd = null;
//            MySqlDataReader rs = null;
//            try
//            {
//                con = new MySqlConnection(chaine);
//                con.Open();
//                cmd = new MySqlCommand(req, con);
//                rs = cmd.ExecuteReader();
//                while (rs.Read())
//                {
//                    client p = new client(rs.GetString(0), rs.GetString(1), rs.GetString(2), rs.GetString(3), rs.GetString(4), rs.GetString(5), rs.GetString(6));
//                    l.Add(p);
//                }
//            }
//            catch (MySqlException se)
//            {
//                Console.WriteLine(se.Message);
//            }
//            finally
//            {
//                if (con != null)
//                {
//                    con.Close();
//                }
//            }

//            return l;

//        }


//        //modifier client
//        public static int Modifier(client e)
//        {

//            string req = "update Client set Nom='" + e.getnom() + "', Prenom='" + e.getprenom() + "', Sexe='" + e.getsexe() + "', Adresse='" + e.getadresse() + "', telephone='" + e.gettelephone() + "', cin='" + e.getcin() + "' where code_client='" + e.getnumclient() + "'";
//            string chaine = "Server=localhost;Database=gestion_codevi;Uid=root;Pwd=";
//            MySqlConnection con = null;
//            MySqlCommand cmd = null;
//            int rs = 0;
//            string mesaj;

//            try
//            {
//                con = new MySqlConnection(chaine);
//                con.Open();
//                cmd = new MySqlCommand(req, con);
//                rs = cmd.ExecuteNonQuery();


//            }
//            catch (MySqlException se)
//            {
//                Console.WriteLine("------------------------------");
//                mesaj = se.Message + "Pas de modification !!!";
//                Console.WriteLine(mesaj);
//                Console.WriteLine("------------------------------");
//            }
//            finally
//            {
//                if (con != null)
//                {
//                    con.Close();
//                }
//            }
//            return rs;

//        }
//    }
//}
