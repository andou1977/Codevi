//using MySql.Data.MySqlClient;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ProjetFenetreCodevi
//{
//    class compte
//    {
//        private string codecompte;
//        private string codeclient;
//        private string devise;
//        private string type;

//        private float solde;
//        private string datecreation;
//        private string etat;

//        public compte() { }

//        public compte(string codecompte, string codeclient, string devise, string type, float solde, string datecreation, string etat)
//        {

//            this.codecompte = codecompte;
//            this.codeclient = codeclient;
//            this.devise = devise;
//            this.type = type;
//            this.solde = solde;
//            this.datecreation = datecreation;
//            this.etat = etat;
//        }
//        public void setCodecompte(string codeco)
//        {
//            this.codecompte = codeco;
//        }
//        public void setCodeclient(string codecli)
//        {
//            this.codeclient = codecli;
//        }
//        public void setdevise(string dev)
//        {
//            this.devise = dev;
//        }
//        public void settype(string ty)
//        {
//            this.type = ty;
//        }

//        public void setsolde(float mont)
//        {
//            this.solde = mont;
//        }
//        public void setdatecreation(string datcret)
//        {

//            this.datecreation = datcret;
//        }
//        public void setetat(string et)
//        {
//            this.etat = et;
//        }

//        public string getcodecompte() { return this.codecompte; }
//        public string getcodeclient() { return this.codeclient; }
//        public string getdevise() { return this.devise; }
//        public string gettype() { return this.type; }
//        public float getsolde() { return this.solde; }
//        public string getdatecreation() { return this.datecreation; }
//        public string getetat() { return this.etat; }




//        public string CreerNouveaucompte(string codecompte, string codeclient, string devise, float solde)
//        {



//            //String d = System.DateTime.Now.ToShortDateString();
//            ////convertir date actuel en tableau
//            //string[] td = d.Split('/');
//            ////formater date en format mysql
//            //string datecreer = string.Format("{0}-{1}-{2}", td[2], td[0], td[1]);
//            string f = "activer";
//            string type = "Epargne";


//            string req1 = "insert into compte values('" + codecompte + "','" + codeclient + "','" + devise + "','" + type + "','" + solde + "','" + System.DateTime.Now.ToShortDateString() + "','" + f + "')";

//            string chaineconnexion = "Server=localhost;Database=gestion_codevi;Uid=root;Pwd=";
//            MySqlConnection con = null;
//            MySqlCommand cmd = null;
//            int resultat = 0;
//            string message;

//            try
//            {

//                con = new MySqlConnection(chaineconnexion);
//                con.Open();
//                cmd = new MySqlCommand(req1, con);
//                resultat = cmd.ExecuteNonQuery();

//                if (resultat > 0)
//                {

//                    Console.WriteLine("------------------------------");
//                    message = ("Enregistrement réussi !");
//                    Console.WriteLine(message);
//                    Console.WriteLine("------------------------------");

//                }
//                else
//                {
                 
//                    message = ("Enregistrement echoué !");
                
//                }

//            }
//            catch (MySqlException se)
//            {

               
//                message = se.Message + "Ce compte existe déjà";
               
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

//        public string DesactiverCompte(string codecompte)
//        {


//            string req1 = "update compte set etat='desactiver' where nocompte='" + codecompte + "' ";

//            string chaineconnexion = "Server=localhost;Database=gestion_codevi;Uid=root;Pwd=";
//            MySqlConnection con = null;
//            MySqlCommand cmd = null;
//            int resultat = 0;
//            string message;

//            try
//            {

//                con = new MySqlConnection(chaineconnexion);
//                con.Open();
//                cmd = new MySqlCommand(req1, con);
//                resultat = cmd.ExecuteNonQuery();

//                if (resultat > 0)
//                {

                   
//                    message = ("Desactivation réussie !!");
                  
//                }
//                else
//                {
                   
//                    message = ("Desaction non réussie ");
                   
//                }

//            }
//            catch (MySqlException se)
//            {

               
//                message = se.Message + "Ce compte ne peut pas etre modifié";
              
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

//        public string Pret(string codecompte, float pret, string datepret, string dateremise)
//        {
//            string req = "insert into pret values('" + codecompte + "','" + pret + "','" + datepret + "','" + dateremise + "')";


//            string chaineconnexion = "Server=localhost;Database=gestion_codevi;Uid=root;Pwd=";
//            MySqlConnection con = null;
//            MySqlCommand cmd = null;
//            int resultat = 0;
//            string message;

//            try
//            {

//                con = new MySqlConnection(chaineconnexion);
//                con.Open();
//                cmd = new MySqlCommand(req, con);
//                resultat = cmd.ExecuteNonQuery();

//                if (resultat > 0)
//                {

                  
//                    message = ("insertion réussi !");
                  
//                }
//                else
//                {
                  
//                    message = ("insertion echoué !");
                 
//                }

//            }
//            catch (MySqlException se)
//            {

               
//                message = se.Message + "Ce pret ne peut pas etre effectué";
               
                
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

//        public string Virement(string codecompte1, string codecompte2, float montant, string dattransaction, string utitisteur)
//        {
//            string req = "insert into virement values('" + codecompte1 + "','" + codecompte2 + "','" + montant + "','" + dattransaction + "','" + utitisteur + "')";


//            string chaineconnexion = "Server=localhost;Database=gestion_codevi;Uid=root;Pwd=";
//            MySqlConnection con = null;
//            MySqlCommand cmd = null;
//            int resultat = 0;
//            string message;

//            try
//            {

//                con = new MySqlConnection(chaineconnexion);
//                con.Open();
//                cmd = new MySqlCommand(req, con);
//                resultat = cmd.ExecuteNonQuery();

//                if (resultat > 0)
//                {


//                    message = ("");
//                    Console.WriteLine(message);

//                }
//                else
//                {
                    
//                    message = ("insertion echoué !");
                  
//                }

//            }
//            catch (MySqlException se)
//            {

//                message = se.Message + "Ce virement ne peut pas etre effectuer";
               
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

//        public compte PretRecherche(string codecompte)
//        {
//            compte c = null;


//            string req = "select c.nocompte,c.code_client,c.devise,c.type,c.solde,c.date_creation,c.etat from compte c,pret p where p.nocompte=c.nocompte and p.nocompte='" + codecompte + "'";

//            string chaineconnexion = "Server=localhost;Database=gestion_codevi;Uid=root;Pwd=";
//            MySqlConnection con = null;
//            MySqlCommand cmd = null;
//            MySqlDataReader resultat = null;

//            try
//            {

//                con = new MySqlConnection(chaineconnexion);
//                con.Open();
//                cmd = new MySqlCommand(req, con);
//                resultat = cmd.ExecuteReader();

//                while (resultat.Read())
//                {

//                    ////convertir date recuperee en tableau en la convertissant en chaine
//                    //string d = resultat.GetDateTime(5).ToShortDateString();
//                    //string[] td = d.Split('/');

//                    //string date = string.Format("{0}-{1}-{2}", td[2], td[1], td[0]);
//                    ////jj/mm/aa=>aa/mm/jj conversion pour c# en mysql


//                    //Console.WriteLine(date);
//                    c = new compte(resultat.GetString(0), resultat.GetString(1), resultat.GetString(2), resultat.GetString(3), resultat.GetFloat(4), resultat.GetString(5), resultat.GetString(6));



//                }
//            }
//            catch (MySqlException e)
//            {
//                Console.WriteLine(e.Message);
//            }
//            finally
//            {
//                if (con != null)
//                {
//                    con.Close();
//                }

//            }

//            return c;
//        }
//        public string ActiverCompte(string codecompte)
//        {


//            string req1 = "update compte set etat='activer' where nocompte='" + codecompte + "' ";

//            string chaineconnexion = "Server=localhost;Database=gestion_codevi;Uid=root;Pwd=";
//            MySqlConnection con = null;
//            MySqlCommand cmd = null;
//            int resultat = 0;
//            string message;

//            try
//            {

//                con = new MySqlConnection(chaineconnexion);
//                con.Open();
//                cmd = new MySqlCommand(req1, con);
//                resultat = cmd.ExecuteNonQuery();

//                if (resultat > 0)
//                {

                   
//                    message = ("Activation réussie !!");
                   
//                    //Console.ReadKey();
//                }
//                else
//                {
                   
//                    message = ("Activation non réussie ");
                  
//                }

//            }
//            catch (MySqlException se)
//            {

               
//                message = se.Message + "Ce compte ne peut pas etre modifié";
               
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


//        public static compte RechercherCompte(string codecompte)
//        {

//            compte c = null;

//            string req = "select * from compte where nocompte='" + codecompte + "'";
//            string chaineconnexion = "Server=localhost;Database=gestion_codevi;Uid=root;Pwd=";
//            MySqlConnection con = null;
//            MySqlCommand cmd = null;
//            MySqlDataReader resultat = null;

//            try
//            {

//                con = new MySqlConnection(chaineconnexion);
//                con.Open();
//                cmd = new MySqlCommand(req, con);
//                resultat = cmd.ExecuteReader();

//                while (resultat.Read())
//                {

//                    //convertir date recuperee en tableau en la convertissant en chaine
//                    //string d = resultat.GetDateTime(5).ToShortDateString();
//                    //string[] td = d.Split('/');

//                    //string date = string.Format("{0}-{1}-{2}", td[2], td[1], td[0]);
//                    ////jj/mm/aa=>aa/mm/jj conversion pour c# en mysql


//                    //Console.WriteLine(date);
//                    c = new compte(resultat.GetString(0), resultat.GetString(1), resultat.GetString(2), resultat.GetString(3), resultat.GetFloat(4), resultat.GetString(5), resultat.GetString(6));



//                }
//            }
//            catch (MySqlException e)
//            {
//                Console.WriteLine(e.Message);
//            }
//            finally
//            {
//                if (con != null)
//                {
//                    con.Close();
//                }
//            }

//            return c;
//        }

//        public static compte RechercherCpCL(string codecompte)
//        {

//            compte c = null;

//            string req = "select * from compte where nocompte='" + codecompte + "'";
//            string chaineconnexion = "Server=localhost;Database=gestion_codevi;Uid=root;Pwd=";
//            MySqlConnection con = null;
//            MySqlCommand cmd = null;
//            MySqlDataReader resultat = null;

//            try
//            {

//                con = new MySqlConnection(chaineconnexion);
//                con.Open();
//                cmd = new MySqlCommand(req, con);
//                resultat = cmd.ExecuteReader();

//                while (resultat.Read())
//                {


//                    //if (resultat.GetString(1).Equals(codeclient))
//                    //{

//                    //convertir date recuperee en tableau en la convertissant en chaine
//                    //string d = resultat.GetDateTime(5).ToShortDateString();
//                    //string[] td = d.Split('/');

//                    //string date = string.Format("{0}-{1}-{2}", td[2], td[1], td[0]);
//                    //jj/mm/aa=>aa/mm/jj conversion pour c# en mysql


//                    //Console.WriteLine(date);

//                    c = new compte(resultat.GetString(0), resultat.GetString(1), resultat.GetString(2), resultat.GetString(3), resultat.GetFloat(4), resultat.GetString(5), resultat.GetString(6));
//                }


//                //{
//                //    Console.WriteLine("Les types de comptes ne correspondent pas");
//            }

//            catch (MySqlException e)
//            {
//                Console.WriteLine(e.Message);
//            }
//            finally
//            {
//                if (con != null)
//                {
//                    con.Close();
//                }
//            }

//            return c;
//        }


//        public string ModifierCompte(string codecompte, string devise, string typecompte, float solde)
//        {


//            string req1 = "update compte set devise='" + devise + "','" + typecompte + "','" + solde + "'where nocompte='" + codecompte + "' ";

//            string chaineconnexion = "Server=localhost;Database=gestion_codevi;Uid=root;Pwd=";
//            MySqlConnection con = null;
//            MySqlCommand cmd = null;
//            int resultat = 0;
//            string message;

//            try
//            {

//                con = new MySqlConnection(chaineconnexion);
//                con.Open();
//                cmd = new MySqlCommand(req1, con);
//                resultat = cmd.ExecuteNonQuery();

//                if (resultat > 0)
//                {

                   
//                    message = ("Modification réussi !");
                   
//                }
//                else
//                {
                   
//                    message = ("Modification echoué !");
                   
//                }

//            }
//            catch (MySqlException se)
//            {

                
//                message = se.Message + "Ce compte ne peut pas etre modifier";
               
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



//        public static List<compte> Touscompte()
//        {
//            List<compte> l = new List<compte>();
//            string req = "select * from compte order by nocompte";
//            string chaine = "Server=localhost;Database=gestion_codevi;Uid=root;Pwd=";
//            MySqlConnection con = null;
//            MySqlCommand cmd = null;
//            MySqlDataReader resultat = null;
//            try
//            {
//                con = new MySqlConnection(chaine);
//                con.Open();
//                cmd = new MySqlCommand(req, con);
//                resultat = cmd.ExecuteReader();
//                while (resultat.Read())
//                {

//                    compte c = new compte(resultat.GetString(0), resultat.GetString(1), resultat.GetString(2), resultat.GetString(3), resultat.GetFloat(4), resultat.GetString(5), resultat.GetString(6));

//                    l.Add(c);
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

//        public static List<compte> Touscomptec(string parametre)
//        {
//            List<compte> l = new List<compte>();
//            string req = "select * from compte where nocompte='" + parametre + "'or code_client='" + parametre + "'or devise='" + parametre + "'or type='" + parametre + "'or etat='" + parametre + "'";
//            string chaine = "Server=localhost;Database=gestion_codevi;Uid=root;Pwd=";
//            MySqlConnection con = null;
//            MySqlCommand cmd = null;
//            MySqlDataReader resultat = null;
//            try
//            {
//                con = new MySqlConnection(chaine);
//                con.Open();
//                cmd = new MySqlCommand(req, con);
//                resultat = cmd.ExecuteReader();
//                while (resultat.Read())
//                {

//                    compte c = new compte(resultat.GetString(0), resultat.GetString(1), resultat.GetString(2), resultat.GetString(3), resultat.GetFloat(4), resultat.GetString(5), resultat.GetString(6));


//                    l.Add(c);
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
//        public static string Depotcompte(string codecompte, float nouvosolde)
//        {


//            string req1 = "update compte set solde='" + nouvosolde + "' where nocompte='" + codecompte + "' ";

//            string chaineconnexion = "Server=localhost;Database=gestion_codevi;Uid=root;Pwd=";
//            MySqlConnection con = null;
//            MySqlCommand cmd = null;
//            int resultat = 0;
//            string message;

//            try
//            {

//                con = new MySqlConnection(chaineconnexion);
//                con.Open();
//                cmd = new MySqlCommand(req1, con);
//                resultat = cmd.ExecuteNonQuery();

//                if (resultat > 0)
//                {

                   

//                    message = ("Operation effectuée !!");
//                    //Console.WriteLine(message);
//                    Console.ForegroundColor = ConsoleColor.White;

//                    Console.WriteLine("------------------------------");
//                    //Console.ReadKey();
//                }
//                else
//                {
                    
//                    message = ("Action non réussite ");
                  
//                }

//            }
//            catch (MySqlException se)
//            {

//                //Console.WriteLine("------------------------------");
//                message = se.Message + "Ce compte ne peut pas etre modifie";
//                //Console.WriteLine(message);
//                //Console.WriteLine("------------------------------");
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

//        //     public static void effectuerretrait(string idcompte , float montantt){

//        //        //declaration d'un tableau pour contenir les donnees du fichier
//        //         List<compte> liste=new List<compte>(); 

//        //        //'liste recoit les donnees du fichiers par la fonction listerutilistaeur
//        //        liste = compte.Touscompte();
//        //        try{
//        //            //'declaration de idco qui recoit l'idcompte entré par l'utilisateur
//        //            string idco   = idcompte;
//        //            //'on declare montant qui recoit la valeur entré par l'utilisateur en convertissant cette valeur en numerique
//        //            double montant  = montantt;
//        //            //'declaration de index pour recuperer l'indice ou se trouve l'idclient a rechercher
//        //            int index ;
//        //            //'declaration d l'indice i
//        //            int i ;
//        //            //'declaration de verifier qui nous permettra de savoir si l'operation est effectuée ou pas
//        //            bool verifier  = false;

//        //            //'on parcourt les donnees de la liste jusqu'a la fin
//        //            for i = 0 to liste.Count - 1 Step 1{}
//        //                //'si l'idclient de la liste est egal a ce entré par l'utilisateur on met verifier a true et on recupere l'indice
//        //                If liste(i).idcompte.Equals(idco) Then
//        //                    verifier = True
//        //                    index = i

//        //                End If

//        //            Next
//        //            If verifier = True Then
//        //                Dim c1 As Compte = New Compte(liste(index).idcompte, liste(index).idclient, liste(index).solde, liste(index).typecompte)
//        //                'verification si le solde est superieur ou egal a 100g pour effectuer le retrait,sinon echec
//        //                If liste(index).solde - montant >= 100 Then
//        //                    'affichage de l'id du client 
//        //                    Fenretrait.txtidclient.Text = liste(index).idclient

//        //                    c1.solde += -montant
//        //                    liste.RemoveAt(index)
//        //                    liste.Insert(index, c1)
//        //                    'affichage du nouveau solde du compte
//        //                    Fenretrait.ln1.Visible = True
//        //                    Fenretrait.lblaffichage.Visible = True
//        //                    Fenretrait.lblattribut.Visible = True
//        //                    Fenretrait.txtsolde.Text = liste(index).solde
//        //                Fenretrait.lblaffichage.Text = (liste(index).idcompte & vbCrLf & vbCrLf & vbCrLf & vbCrLf & liste(index).idclient & vbCrLf & vbCrLf & vbCrLf & vbCrLf & montant & vbCrLf & vbCrLf & vbCrLf & vbCrLf & liste(index).solde & vbCrLf & vbCrLf & vbCrLf & vbCrLf & liste(index).typecompte)
//        //                    Compte.ecrireliste(liste)
//        //                    Fenretrait.lblresult.ForeColor = Color.Green
//        //                    Fenretrait.lblresult.Text = "Retrait effectué avec succès, Merci!"

//        //                Else
//        //                    Fenretrait.lblresult.Text = "Retrait non effectué, le solde restant doit etre au moins egal à 100HTG"
//        //                End If

//        //            Else
//        //                Fenretrait.lblresult.Text = "Compte inconnu, verifier le numero du compte!"
//        //            End If
//        //        Catch ex As Exception
//        //            MsgBox(ex.Message)
//        //        End Try


//        //}
//        //}




//        public static float depotcompte(float a, float b)
//        {



//            float depot;
//            depot = a + b;

//            return depot;

//        }


//        public static float retraitcompte(float a, float b)
//        {



//            float depot;
//            depot = a - b;

//            return depot;

//        }
//    }


//}
