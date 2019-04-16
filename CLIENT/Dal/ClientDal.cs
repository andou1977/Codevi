//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Com.ProjetCodevi.Domaine;
//using MySql.Data.MySqlClient;
//namespace Com.ProjetCodevi.Dal
//{
//    public class ClientDal
//    {
//        //insertion d un client

//        public static int insererclient(Client c1)
//        {

//            int message = 0;

//            string chaine = "Server=localhost;Database=gestion_codevi;Uid=root;Pwd=";
//            MySqlCommand cmd = null; ;
//            MySqlConnection con = null;
//            int verif = 0;
//            string requet = "insert into client values('" + c1.getnumclient() + "','" + c1.getnom() + "','" + c1.getprenom() + "','" + c1.getsexe() + "','" + c1.getadresse() + "','" + c1.gettelephone() + "','" + c1.getcin() + "','" + c1.getemail() + "')";
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
//            catch (MySqlException)
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
//        public static Client rechercherclient(string codeclient)
//        {
//            Client et = null;


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

//                    et = new Client(rs.GetString(0), rs.GetString(1), rs.GetString(2), rs.GetString(3), rs.GetString(4), rs.GetString(5), rs.GetString(6),rs.GetString(7));


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
//        public static List<Client> Tousclients(string parametre)
//        {
//            List<Client> l = null;
//            l = new List<Client>();
//            string req = "select * from client where code_client='" + parametre + "' or nom='" + parametre + "'or prenom='" + parametre + "'or sexe='" + parametre + "'or adresse='" + parametre + "'or telephone='" + parametre + "'or cin='" + parametre + "' or email='" + parametre + "' order by code_client";
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
//                    Client p = new Client(rs.GetString(0), rs.GetString(1), rs.GetString(2), rs.GetString(3), rs.GetString(4), rs.GetString(5), rs.GetString(6),rs.GetString(7));
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

//        public static List<Client> Tousclient()
//        {
//            List<Client> l = null;
//            l = new List<Client>();
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
//                    Client p = new Client(rs.GetString(0), rs.GetString(1), rs.GetString(2), rs.GetString(3), rs.GetString(4), rs.GetString(5), rs.GetString(6),rs.GetString(7));
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
//        public static int Modifier(Client e)
//        {

//            string req = "update Client set Nom='" + e.getnom() + "', Prenom='" + e.getprenom() + "', Sexe='" + e.getsexe() + "', Adresse='" + e.getadresse() + "', telephone='" + e.gettelephone() + "', cin='" + e.getcin() + "',email='" + e.getemail() + "' where code_client='" + e.getnumclient() + "'";
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
