using Com.ProjetCodevi.Domaine;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.ProjetCodevi.Dal
{
  public  class PretDal
    {

        public static Pret Rechercher(string code)
        {
            Pret p = null;

            string req = "select *from pret where nocompte='" + code + "'";
            string chcon = "Server=localhost;Database=gestion_codevi;Uid=root;Pwd=";
            MySqlConnection con = null;
            MySqlCommand cmd = null;
            MySqlDataReader rs = null;
            try
            {
                con = new MySqlConnection(chcon);
                con.Open();
                cmd = new MySqlCommand(req, con);
                rs = cmd.ExecuteReader();
                while (rs.Read())
                {
                    ////convertir date recuperee en tableau en la convertissant en chaine
                    //string d = rs.GetDateTime(3).ToShortDateString();
                    //string[] td = d.Split('/');

                    //string date = string.Format("{0}-{1}-{2}", td[2], td[1], td[0]);
                    ////jj/mm/aa=>aa/mm/jj conversion pour c# en mysql


                    //string d1 = rs.GetDateTime(4).ToShortDateString();
                    //string[] td1 = d1.Split('/');


                    //string date1 = string.Format("{0}-{1}-{2}", td1[2], td1[1], td1[0]);
                    ////jj/mm/aa=>aa/mm/jj conversion pour c# en mysql
                    ////Console.WriteLine(date);
                    //Console.WriteLine(date1);



                    p = new Pret(rs.GetString(0), rs.GetString(1), rs.GetInt32(2), rs.GetString(3), rs.GetDateTime(4).Date.ToString(), rs.GetDateTime(5));
                }
            }
            catch (MySqlException se)
            {
                throw new Exception(se.Message);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }

            return p;

        }


        public static Pret Remboursement(string code)
        {
            Pret p = null;

            string req = "select *from pret where nocompte='" + code + "'";
            string chcon = "Server=localhost;Database=gestion_codevi;Uid=root;Pwd=";
            MySqlConnection con = null;
            MySqlCommand cmd = null;
            MySqlDataReader rs = null;
            try
            {
                con = new MySqlConnection(chcon);
                con.Open();
                cmd = new MySqlCommand(req, con);
                rs = cmd.ExecuteReader();
                while (rs.Read())
                {

                    string d1 = rs.GetDateTime(3).ToShortDateString();
                    //string[] td1 = d1.Split('/');

                    //formater date en format c#
                    //string date1 = string.Format("{0}-{1}-{2}", td1[2], td1[1], td1[0]);
                    //string d2 = rs.GetDateTime(4).ToShortDateString();
                    //string[] td2 = d2.Split('/');

                    //formater date en format c#
                    //string date2 = string.Format("{0}-{1}-{2}", td2[2], td2[1], td2[0]);
                    p = new Pret(rs.GetString(0), rs.GetString(1), rs.GetFloat(2), rs.GetString(3), d1, rs.GetDateTime(5));

                }
            }
            catch (MySqlException se)
            {
                throw new Exception(se.Message);

            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }

            return p;


        }


        public static string rembourserdette(string codecompte, float montant)
        {


            string req1 = "update pret set montant='" + montant + "' where nocompte='" + codecompte + "' ";

            string chaineconnexion = "Server=localhost;Database=gestion_codevi;Uid=root;Pwd=";
            MySqlConnection con = null;
            MySqlCommand cmd = null;
            int resultat = 0;
            string message;

            try
            {

                con = new MySqlConnection(chaineconnexion);
                con.Open();
                cmd = new MySqlCommand(req1, con);
                resultat = cmd.ExecuteNonQuery();

                if (resultat > 0)
                {


                    message = ("Activation réussie !!");

                }
                else
                {

                    message = ("Activation non réussie ");

                }

            }
            catch (MySqlException se)
            {


                message = se.Message + "Ce compte ne peut pas etre modifié";

            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
            return message;

        }



        public static Pret RechercherPret(string code)
        {
            Pret e = null;

            string req = "select *from pret where nocompte='" + code + "'";
            string chcon = "Server=localhost;Database=gestion_codevi;Uid=root;Pwd=";
            MySqlConnection con = null;
            MySqlCommand cmd = null;
            MySqlDataReader rs = null;
            try
            {
                con = new MySqlConnection(chcon);
                con.Open();
                cmd = new MySqlCommand(req, con);
                rs = cmd.ExecuteReader();
                while (rs.Read())
                {

                    e = new Pret(rs.GetString(0), rs.GetString(1), rs.GetFloat(2), rs.GetString(3), rs.GetString(4), rs.GetDateTime(5));

                }
            }
            catch (MySqlException se)
            {
                Console.WriteLine(se.Message);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }

            return e;

        }
        public static Pret RechercherParmois(string code)
        {
            Pret e = null;

            string req = "select *from parmois where nocompte='" + code + "'";
            string chcon = "Server=localhost;Database=gestion_codevi;Uid=root;Pwd=";
            MySqlConnection con = null;
            MySqlCommand cmd = null;
            MySqlDataReader rs = null;
            try
            {
                con = new MySqlConnection(chcon);
                con.Open();
                cmd = new MySqlCommand(req, con);
                rs = cmd.ExecuteReader();
                while (rs.Read())
                {

                    e = new Pret(rs.GetString(0), rs.GetFloat(1));

                }
            }
            catch (MySqlException se)
            {
                Console.WriteLine(se.Message);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }

            return e;

        }
        public static Pret RechercherPretarembourser(string code)
        {
            Pret e = null;
            string req = "select *from pretarembourser where nocompte='" + code + "'";
            string chcon = "Server=localhost;Database=gestion_codevi;Uid=root;Pwd=";
            MySqlConnection con = null;
            MySqlCommand cmd = null;
            MySqlDataReader rs = null;
            try
            {
                con = new MySqlConnection(chcon);
                con.Open();
                cmd = new MySqlCommand(req, con);
                rs = cmd.ExecuteReader();
                while (rs.Read())
                {
                    e = new Pret(rs.GetString(0), rs.GetString(1), rs.GetFloat(2), rs.GetString(3), rs.GetString(4), rs.GetDateTime(5));
                }
            }
            catch (MySqlException se)
            {
                throw new Exception(se.Message);

            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }

            return e;

        }


        public static Pret RechercherPretclient(string code)
        {
            Pret e = null;

            string req = "select *from pret where code_client='" + code + "'";
            string chcon = "Server=localhost;Database=gestion_codevi;Uid=root;Pwd=";
            MySqlConnection con = null;
            MySqlCommand cmd = null;
            MySqlDataReader rs = null;
            try
            {
                con = new MySqlConnection(chcon);
                con.Open();
                cmd = new MySqlCommand(req, con);
                rs = cmd.ExecuteReader();
                while (rs.Read())
                {

                    e = new Pret(rs.GetString(0), rs.GetString(1), rs.GetFloat(2), rs.GetString(3), rs.GetString(4), rs.GetDateTime(5));

                }
            }
            catch (MySqlException se)
            {
                throw new Exception(se.Message);

            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }

            return e;

        }


        public static int Modifierpret(string numerocompte, float reste)
        {

            string req = "update pretarembourser set montant='" + reste + "' where nocompte='" + numerocompte + "'";
            string chaine = "Server=localhost;Database=gestion_codevi;Uid=root;Pwd=";
            MySqlConnection con = null;
            MySqlCommand cmd = null;
            int rs = 0;
            string mesaj = "";

            try
            {
                con = new MySqlConnection(chaine);
                con.Open();
                cmd = new MySqlCommand(req, con);
                rs = cmd.ExecuteNonQuery();


            }
            catch (MySqlException se)
            {

                //mesaj = se.Message + "Pas de modification !!!";
                //Console.WriteLine(mesaj);
                //Console.WriteLine("------------------------------");
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
            return rs;

        }

        public static List<Pret> TousPret()
        {
            List<Pret> l = new List<Pret>();
            string req = "select * from pret order by nocompte";
            string chaine = "Server=localhost;Database=gestion_codevi;Uid=root;Pwd=";
            MySqlConnection con = null;
            MySqlCommand cmd = null;
            MySqlDataReader rs = null;
            try
            {
                con = new MySqlConnection(chaine);
                con.Open();
                cmd = new MySqlCommand(req, con);
                rs = cmd.ExecuteReader();
                while (rs.Read())
                {

                    Pret c = new Pret(rs.GetString(0), rs.GetString(1), rs.GetFloat(2), rs.GetString(3), rs.GetString(4), rs.GetDateTime(5)); ;

                    l.Add(c);
                }
            }
            catch (MySqlException se)
            {
                Console.WriteLine(se.Message);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }

            return l;

        }




        public static List<Pret> TousPretcritere(string param)
        {
            List<Pret> l = new List<Pret>();
            string req = "select * from pret where nocompte='" + param + "' or code_client='" + param + "' or montant='" + param + "' or devise='" + param + "' or date_pret='" + param + "' or date_remise='" + param + "'";
            string chaine = "Server=localhost;Database=gestion_codevi;Uid=root;Pwd=";
            MySqlConnection con = null;
            MySqlCommand cmd = null;
            MySqlDataReader rs = null;
            try
            {
                con = new MySqlConnection(chaine);
                con.Open();
                cmd = new MySqlCommand(req, con);
                rs = cmd.ExecuteReader();
                while (rs.Read())
                {

                    Pret c = new Pret(rs.GetString(0), rs.GetString(1), rs.GetFloat(2), rs.GetString(3), rs.GetString(4), rs.GetDateTime(5)); ;

                    l.Add(c);
                }
            }
            catch (MySqlException se)
            {
                Console.WriteLine(se.Message);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }

            return l;

        }







        public static string Pret(string codecompte, string codecl, float pret, string devise, string datepret, string dateremise)
        {
            string req = "insert into pret values('" + codecompte + "','" + codecl + "','" + pret + "','" + devise + "','" + datepret + "','" + dateremise + "')";


            string chaineconnexion = "Server=localhost;Database=gestion_codevi;Uid=root;Pwd=";
            MySqlConnection con = null;
            MySqlCommand cmd = null;
            int resultat = 0;
            string message = null;

            try
            {

                con = new MySqlConnection(chaineconnexion);
                con.Open();
                cmd = new MySqlCommand(req, con);
                resultat = cmd.ExecuteNonQuery();

                if (resultat > 0)
                {

                    message = ("Pret Effectué !");

                }
                else
                {

                    message = ("insertion echoué !");

                }

            }
            catch (MySqlException se)
            {


                message = se.Message + "Ce pret ne peut pas etre effectu";

            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
            return message;

        }
        public static string parmois(string codecompte, float pret)
        {
            string req = "insert into parmois values('" + codecompte + "','" + pret + "')";


            string chaineconnexion = "Server=localhost;Database=gestion_codevi;Uid=root;Pwd=";
            MySqlConnection con = null;
            MySqlCommand cmd = null;
            int resultat = 0;
            string message = null;

            try
            {

                con = new MySqlConnection(chaineconnexion);
                con.Open();
                cmd = new MySqlCommand(req, con);
                resultat = cmd.ExecuteNonQuery();

                if (resultat > 0)
                {

                    message = ("Pret Effectué !");

                }
                else
                {

                    message = ("insertion echoué !");

                }

            }
            catch (MySqlException se)
            {


                message = se.Message + "Ce pret ne peut pas etre effectué";

            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
            return message;

        }
        public static string prepourremboursement(string codecompte, string codecl, float pret, string devise, string datepret, string dateremise)
        {

            string req = "insert into pretarembourser values('" + codecompte + "','" + codecl + "','" + pret + "','" + devise + "','" + datepret + "','" + dateremise + "')";


            string chaineconnexion = "Server=localhost;Database=gestion_codevi;Uid=root;Pwd=";
            MySqlConnection con = null;
            MySqlCommand cmd = null;
            int resultat = 0;
            string message = null;

            try
            {

                con = new MySqlConnection(chaineconnexion);
                con.Open();
                cmd = new MySqlCommand(req, con);
                resultat = cmd.ExecuteNonQuery();

                if (resultat > 0)
                {

                }
                else
                {

                }

            }
            catch (MySqlException se)
            {

            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
            return message;
        }
        //public string enregistrerKobpeye(string codecompte, float pret)
        //{
        //    string req = "insert into montantapayer values('" + codecompte + "','" + pret + "')";


        //    string chaineconnexion = "Server=localhost;Database=gestion_codevi;Uid=root;Pwd=";
        //    MySqlConnection con = null;
        //    MySqlCommand cmd = null;
        //    int resultat = 0;
        //    string message = null;

        //    try
        //    {

        //        con = new MySqlConnection(chaineconnexion);
        //        con.Open();
        //        cmd = new MySqlCommand(req, con);
        //        resultat = cmd.ExecuteNonQuery();

        //        if (resultat > 0)
        //        {

        //            message = ("Effectué !");

        //        }
        //        else
        //        {

        //            message = ("insertion echoué !");

        //        }

        //    }
        //    catch (MySqlException se)
        //    {


        //        message = se.Message + "pwoblem";

        //    }
        //    finally
        //    {
        //        if (con != null)
        //        {
        //            con.Close();
        //        }
        //    }
        //    return message;

        //}

        public static void effacerPret(string numero)
        {
            string req2 = "delete from pret where nocompte='" + numero + "'";
            MySqlConnection con = null;
            MySqlCommand cmd = null;
            string chcon = "Server=localhost;Database=gestion_codevi;Uid=root;Pwd=";
            int rs;
            try
            {
                con = new MySqlConnection(chcon);
                con.Open();
                cmd = new MySqlCommand(req2, con);
                rs = cmd.ExecuteNonQuery();


                if (rs > 0)
                {


                }
                else
                {

                }


                // MessageBox.Show("Remboursement reussi!");

            }
            catch (MySqlException se)
            {

                //MessageBox.Show(se.Message + "Pas de Suppression !!! ");


            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }



        }
        public static void effacerPretarembourser(string numero)
        {
            string req2 = "delete from pretarembourser where nocompte='" + numero + "'";
            MySqlConnection con = null;
            MySqlCommand cmd = null;
            string chcon = "Server=localhost;Database=gestion_codevi;Uid=root;Pwd=";
            int rs;
            try
            {
                con = new MySqlConnection(chcon);
                con.Open();
                cmd = new MySqlCommand(req2, con);
                rs = cmd.ExecuteNonQuery();


                if (rs > 0)
                {


                }
                else
                {

                }


                // MessageBox.Show("Remboursement reussi!");

            }
            catch (MySqlException se)
            {

                //MessageBox.Show(se.Message + "Pas de Suppression !!! ");


            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }
        public static void effacerparmois(string numero)
        {
            string req2 = "delete from parmois where nocompte='" + numero + "'";
            MySqlConnection con = null;
            MySqlCommand cmd = null;
            string chcon = "Server=localhost;Database=gestion_codevi;Uid=root;Pwd=";
            int rs;
            try
            {
                con = new MySqlConnection(chcon);
                con.Open();
                cmd = new MySqlCommand(req2, con);
                rs = cmd.ExecuteNonQuery();


                if (rs > 0)
                {


                }
                else
                {

                }


                // MessageBox.Show("Remboursement reussi!");

            }
            catch (MySqlException se)
            {

                //MessageBox.Show(se.Message + "Pas de Suppression !!! ");


            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }



        }
        //public static void effacerKobpeye(string numero)
        //{
        //    string req2 = "delete from montantapayer where numerocompte='" + numero + "'";
        //    MySqlConnection con = null;
        //    MySqlCommand cmd = null;
        //    string chcon = "Server=localhost;Database=gestion_codevi;Uid=root;Pwd=";
        //    int rs;
        //    try
        //    {
        //        con = new MySqlConnection(chcon);
        //        con.Open();
        //        cmd = new MySqlCommand(req2, con);
        //        rs = cmd.ExecuteNonQuery();


        //        if (rs > 0)
        //        {


        //        }
        //        else
        //        {

        //        }


        //        // MessageBox.Show("Remboursement reussi!");

        //    }
        //    catch (MySqlException se)
        //    {

        //        //MessageBox.Show(se.Message + "Pas de Suppression !!! ");


        //    }
        //    finally
        //    {
        //        if (con != null)
        //        {
        //            con.Close();
        //        }
        //    }



        //}

        public static Pret RechercherClient(string codecl)
        {
            Pret p = null;

            string req = "select *from pret where code_client='" + codecl + "'";
            string chcon = "Server=localhost;Database=gestion_codevi;Uid=root;Pwd=";
            MySqlConnection con = null;
            MySqlCommand cmd = null;
            MySqlDataReader rs = null;
            try
            {
                con = new MySqlConnection(chcon);
                con.Open();
                cmd = new MySqlCommand(req, con);
                rs = cmd.ExecuteReader();
                while (rs.Read())
                {



                    p = new Pret(rs.GetString(0), rs.GetString(1), rs.GetInt32(2), rs.GetString(3), rs.GetString(4), rs.GetDateTime(5));
                }
            }
            catch (MySqlException se)
            {
                throw new Exception(se.Message);

            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }

            return p;

        }
        //public static float RechercherKobpeye(string code)
        //{
        //    float apayer=0;

        //    string req = "select * from montantapayer where numerocompte='" + code + "'";
        //    string chcon = "Server=localhost;Database=gestion_codevi;Uid=root;Pwd=";
        //    MySqlConnection con = null;
        //    MySqlCommand cmd = null;
        //    MySqlDataReader rs = null;
        //    try
        //    {
        //        con = new MySqlConnection(chcon);
        //        con.Open();
        //        cmd = new MySqlCommand(req, con);
        //        rs = cmd.ExecuteReader();
        //        while (rs.Read())
        //        {

        //            apayer = rs.GetFloat(1);


        //        }
        //    }
        //    catch (MySqlException se)
        //    {
        //        Console.WriteLine(se.Message);
        //    }
        //    finally
        //    {
        //        if (con != null)
        //        {
        //            con.Close();
        //        }
        //    }

        //    return apayer;

        //}
        public static void indexe(string numero, float apayer, string devise, string d, string d1, string utilisateur)
        {



            //convertir date actuelle en tableau
            string[] td = d.Split('/');


            //convertir date actuelle en tableau
            string[] td1 = d1.Split('/');


            String d24 = System.DateTime.Now.ToShortDateString();
            string req1 = "insert into indexe_pret values ('" + numero + "','" + apayer + "','" + devise + "','" + d + "','" + d1 + "','" + d24 + "','" + utilisateur + "')";

            string chcon = "Server=localhost;Database=gestion_codevi;Uid=root;Pwd=";
            MySqlConnection con = null;
            MySqlCommand cmd = null;
            int rs;


            try
            {
                con = new MySqlConnection(chcon);
                con.Open();
                cmd = new MySqlCommand(req1, con);
                rs = cmd.ExecuteNonQuery();


                if (rs > 0)
                {


                }
                else
                {

                }
            }
            catch (MySqlException se)
            {

                //=se.Message + "Pas d'insertion !!! ");

            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        public static void EnregistrerTransaction(string numero, string description, float montant, DateTime date_transaction, string utilisateur)
        {



            //DateTime dat = DateTime.Now.Date;
            //DateTime heure = DateTime.Now.Hour();
            //string utilisateur = "william";

            //declaration date actuelle, conversion en chaine
            String d = date_transaction.ToShortDateString();

            ////convertir date actuelle en tableau
            //string[] td = d.Split('/');

            ////formater date en format mysql (date-mois-jour)
            //string dat = string.Format("{0}-{1}-{2}", td[2], td[1], td[0]);




            string req1 = "insert into transaction values ('" + numero + "','" + description + "','" + montant + "','" + d + "','" + utilisateur + "')";

            string chcon = "Server=localhost;Database=gestion_codevi;Uid=root;Pwd=";
            MySqlConnection con = null;
            MySqlCommand cmd = null;
            int rs;
            string mesaj;

            try
            {
                con = new MySqlConnection(chcon);
                con.Open();
                cmd = new MySqlCommand(req1, con);
                rs = cmd.ExecuteNonQuery();


                if (rs > 0)
                {
                    //Console.WriteLine("------------------------------");
                    //mesaj = ("insertion réussie !");
                    //Console.WriteLine(mesaj);
                    //Console.WriteLine("------------------------------");
                    //Console.ReadKey();

                }
                else
                {
                    //Console.WriteLine("------------------------------");
                    mesaj = ("insertion echouée !");
                    //Console.WriteLine(mesaj);
                    //Console.WriteLine("------------------------------");
                }



            }
            catch (MySqlException se)
            {
                //Console.WriteLine("------------------------------");
                mesaj = se.Message + "Pas d'insertion !!! ";
                //Console.WriteLine(mesaj);
                //Console.WriteLine("------------------------------");
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }
    }
}
