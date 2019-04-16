//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using MySql.Data.MySqlClient;

//namespace ProjetFenetreCodevi
//{
//    class Utilisateur
//    {
//        private string _code;
//        private string _nom;
//        private string _prenom;
//        private string _pseudo;
//        private string _motdepasse;
//        private string _droitacces;
//        private string _etatcompte;
//        private string _date;
//        private byte[] _photo;

//        //constructeur par default
//        public Utilisateur()
//        {
//        }
//        //constructeur avec parametre
//        public Utilisateur(string code, string nom, string prenom, string pseudo, string motdepasse, string droitacces, string etatcompte, string date,byte[] photo)
//        {
//            this._code = code;
//            this._nom = nom;
//            this._prenom = prenom;
//            this._pseudo = pseudo;
//            this._motdepasse = motdepasse;
//            this._droitacces = droitacces;
//            this._etatcompte = etatcompte;
//            this._date = date;
//            this._photo=photo;
//        }

//        public Utilisateur(string code, string nom, string prenom, string pseudo, string motdepasse, string droitacces, string etatcompte, string date)
//        {
//            this._code = code;
//            this._nom = nom;
//            this._prenom = prenom;
//            this._pseudo = pseudo;
//            this._motdepasse = motdepasse;
//            this._droitacces = droitacces;
//            this._etatcompte = etatcompte;
//            this._date = date;
//        }

//        public Utilisateur(string code, string nom, string prenom, string pseudo, string motdepasse, string droitacces, string etatcompte)
//        {
//            this._code = code;
//            this._nom = nom;
//            this._prenom = prenom;
//            this._pseudo = pseudo;
//            this._motdepasse = motdepasse;
//            this._droitacces = droitacces;
//            this._etatcompte = etatcompte;
           
//        }



//        public Utilisateur(string code, string pseudo, string motdepasse)
//        {
//            this._code = code;
          
//            this._pseudo = pseudo;
//            this._motdepasse = motdepasse;
         

//        }
//        //mutateur
//        public string Get_code()
//        {
//            return this._code;
//        }
//        public string Get_nom()
//        {
//            return this._nom;
//        }
//        public string Get_prenom()
//        {
//            return this._prenom;
//        }
//        public string Get_pseudo()
//        {
//            return this._pseudo;
//        }
//        public string Get_motdepasse()
//        {
//            return this._motdepasse;
//        }
//        public string Get_droitacces()
//        {
//            return this._droitacces;
//        }
//        public string Get_etatcompte()
//        {
//            return this._etatcompte;
//        }
//        public string Get_date()
//        {
//            return this._date;
//        }
//        public byte[] Get_photo()
//        {
//            return this._photo;
//        }
//        //accesseur
//        public void Set_code(string code)
//        {
//            _code = code;
//        }
//        public void Set_nom(string nom)
//        {
//            _nom = nom;
//        }
//        public void Set_prenom(string prenom)
//        {
//            _prenom = prenom;
//        }
//        public void Set_pseudo(string pseudo)
//        {
//            _pseudo = pseudo;
//        }
//        public void Set_motdepasse(string motdepasse)
//        {
//            _motdepasse = motdepasse;
//        }
//        public void Set_droitacces(string droitacces)
//        {
//            _droitacces = droitacces;
//        }
//        public void Set_etatcompte(string etatcompte)
//        {
//            _etatcompte = etatcompte;
//        }
//        public void Set_date(string date)
//        {
//            _date = date;
//        }
//        public void Set_photo(byte[] photo)
//        {
//            _photo = photo;
//        }
//        public static Utilisateur connexion(string pseudo, string modpas)
//        {

//            Utilisateur u = null;
//            string chaine = "Server=localhost;Database=gestion_codevi;Uid=root;Pwd=";
//            MySqlCommand cmd = null; ;
//            MySqlConnection con = null;
//            MySqlDataReader rs = null;

//            string requet = "select * from utilisateur where pseudo='" + pseudo + "' and motdepasse='" + modpas + "' ";
//            try
//            {

//                con = new MySqlConnection(chaine);
//                con.Open();
//                cmd = new MySqlCommand(requet, con);
//                rs = cmd.ExecuteReader();
//                if (rs.Read())
//                {

//                    u = new Utilisateur(rs.GetString(0), rs.GetString(1), rs.GetString(2), rs.GetString(3), rs.GetString(4), rs.GetString(5), rs.GetString(6), rs.GetString(7));

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

//            return u;
//        }


//        //Ajouterutilisateur
//        public int AjouterUtilisateur()
//        {


//            int resu = 0;
//            string bd = "Server=localhost;Database=gestion_codevi;Uid=root;Pwd=";
//            MySqlConnection con = null;
//            MySqlCommand cmd = null;

//            try
//            {

//                con = new MySqlConnection(bd);
//                con.Open();
//                string req = "insert into utilisateur values (@code,'" + this.Get_nom() + "','" + this.Get_prenom() + "','" + this.Get_pseudo() + "','" + this.Get_motdepasse() + "','" + this.Get_droitacces() + "','" + this.Get_etatcompte() + "','" + this.Get_date() + "')";
//                cmd = new MySqlCommand(req, con);
//                cmd.Parameters.AddWithValue("@code", this.Get_code());
               
//                resu = cmd.ExecuteNonQuery();
//                if (resu == 0)
//                {
//                    Console.WriteLine("Insertion Echouee");
//                }
//                else
//                {
//                    Console.WriteLine("Insertion reussie");
//                }

//                con.Close();

//            }
//            catch (MySqlException e)
//            {
//                Console.WriteLine("message" + e);
//            }
//            return resu;
//        }


//        //ajouter utilisateur avec photo
//        public int AjouterUtilisateurphoto()
//        {


//            int resu = 0;
//            string bd = "Server=localhost;Database=gestion_codevi;Uid=root;Pwd=";
//            MySqlConnection con = null;
//            MySqlCommand cmd = null;

//            try
//            {

//                con = new MySqlConnection(bd);
//                con.Open();
//                //cmd.Parameters.Add("@photo", MySqlDbType.Blob).Value = this.Get_photo();
//                string req = "insert into utilisateurphoto values ('" + this.Get_code() + "','" + this.Get_nom() + "','" + this.Get_prenom() + "','" + this.Get_pseudo() + "','" + this.Get_motdepasse() + "','" + this.Get_droitacces() + "','" + this.Get_etatcompte() + "','" + this.Get_date() + ",@photo)";
              
//                cmd = new MySqlCommand(req, con);
//                cmd.Parameters.AddWithValue("@photo", MySqlDbType.Blob).Value = this.Get_photo();
               
//                resu = cmd.ExecuteNonQuery();
//                if (resu == 0)
//                {
//                    Console.WriteLine("Insertion Echouee");
//                }
//                else
//                {
//                    Console.WriteLine("Insertion reussie");
//                }

//                con.Close();

//            }
//            catch (MySqlException e)
//            {
//                Console.WriteLine("message" + e);
//            }
//            return resu;
//        }
//        //ListerUtilisateur
//        public static List<Utilisateur> listerutilisateuractif()
//        {
//            List<Utilisateur> l = null;
//            l = new List<Utilisateur>();
//            //new List<client>();
//            string req = "select * from utilisateur where etatcompte='activer'";
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
//                    Utilisateur p = new Utilisateur(rs.GetString(0), rs.GetString(1), rs.GetString(2), rs.GetString(3), rs.GetString(4), rs.GetString(5), rs.GetString(6), rs.GetString(7));
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


//        public static List<Utilisateur> listerutilisateurinactif()
//        {
//            List<Utilisateur> l = null;
//            l = new List<Utilisateur>();
//            //new List<client>();
//            string req = "select * from utilisateur where etatcompte='desactiver'";
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
//                    Utilisateur p = new Utilisateur(rs.GetString(0), rs.GetString(1), rs.GetString(2), rs.GetString(3), rs.GetString(4), rs.GetString(5), rs.GetString(6), rs.GetString(7));
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


//        //recherche
//        public Utilisateur RechercherUtilisateur(string code)
//        {
//            Utilisateur util = null;

//            string connection = "Server=localhost;Database=gestion_codevi;Uid=root;Pwd=";
//            MySqlCommand cmd = null;
//            MySqlConnection con = null;
//            string req2 = "select * from utilisateur where code='" + code + "'";

//            MySqlDataReader result = null;

//            try
//            {

//                con = new MySqlConnection(connection);
//                con.Open();
//                cmd = new MySqlCommand(req2, con);
//                result = cmd.ExecuteReader();
//                if (result.Read())
//                {
//                    util = new Utilisateur(result.GetString(0), result.GetString(1), result.GetString(2), result.GetString(3), result.GetString(4), result.GetString(5), result.GetString(6), result.GetString(7));
//                }

//            }

//            catch (MySqlException e)
//            {

//                Console.WriteLine("Message" + e);
//            }
//            finally
//            {
//                con.Close();
//            }
//            return util;

//        }
//        public static Utilisateur RechercherPseudo(string pseudo,string motpass)
//        {
//            Utilisateur util = null;

//            string connection = "Server=localhost;Database=gestion_codevi;Uid=root;Pwd=";
//            MySqlCommand cmd = null;
//            MySqlConnection con = null;
//            string req2 = "select * from utilisateur where pseudo='" + pseudo + "'";

//            MySqlDataReader result = null;

//            try
//            {

//                con = new MySqlConnection(connection);
//                con.Open();
//                cmd = new MySqlCommand(req2, con);
//                result = cmd.ExecuteReader();
//                if (result.Read())
//                {
//                    util = new Utilisateur(result.GetString(0), result.GetString(1), result.GetString(2), result.GetString(3), result.GetString(4), result.GetString(5), result.GetString(6), result.GetString(7));
//                }

//            }

//            catch (MySqlException e)
//            {

//                Console.WriteLine("Message" + e);
//            }
//            finally
//            {
//                con.Close();
//            }
//            return util;

//        }


//        //modifier utilisateur
//        public int ModifierUtilisateur(string code, string nom, string prenom, string pseudo, string motdepasse,string droit,string etat)
//        {
//            Utilisateur util = new Utilisateur();

//            util = util.RechercherUtilisateur(code);

//            int resu = 0;
//            string bd = "Server=localhost;Database=gestion_codevi;Uid=root;Pwd=";
//            MySqlConnection con = null;
//            MySqlCommand cmd = null;

//            try
//            {

//                con = new MySqlConnection(bd);
//                con.Open();
//                string req = "update  utilisateur set nom='" + this.Get_nom() + "',prenom='" + this.Get_prenom() + "',pseudo='" + this.Get_pseudo() + "',motdepasse='" + this.Get_motdepasse() + "',droitacces='" + droit + "',etatcompte='" + etat + "' where code='" + code + "'";
//                cmd = new MySqlCommand(req, con);
//                resu = cmd.ExecuteNonQuery();
//                if (resu == 0)
//                {
//                    Console.WriteLine("Modification Echouee");
//                }
//                else
//                {
//                    Console.WriteLine();
//                    Console.WriteLine("Modification reussie");
//                }

//                con.Close();

//            }
//            catch (MySqlException e)
//            {
//                Console.WriteLine("message" + e);
//            }

//            return resu;
//        }



//        public int ModifierSonCompte(string code, string pseudo, string motdepasse)
//        {
           

//            int resu = 0;
//            string bd = "Server=localhost;Database=gestion_codevi;Uid=root;Pwd=";
//            MySqlConnection con = null;
//            MySqlCommand cmd = null;

//            try
//            {

//                con = new MySqlConnection(bd);
//                con.Open();
//                string req = "update  utilisateur set pseudo='" + pseudo + "',motdepasse='" + motdepasse+ "' where code='" + code + "'";
//                cmd = new MySqlCommand(req, con);
//                resu = cmd.ExecuteNonQuery();
//                if (resu == 0)
//                {
                    
//                }
//                else
//                {
                   
//                }

//                con.Close();

//            }
//            catch (MySqlException e)
//            {
               
//            }

//            return resu;
//        }


//        //SupprimerUtilisateur
//        public void SupprimerUtilisateur(string code)
//        {
//            Utilisateur util = new Utilisateur();
//            util = util.RechercherUtilisateur(code);
//            int resu = 0;
//            string bd = "Server=localhost;Database=gestion_codevi;Uid=root;Pwd=";
//            MySqlConnection con = null;
//            MySqlCommand cmd = null;
//            MySqlCommand cmd1 = null;
//            DateTime date = DateTime.Now;
//            try
//            {

//                con = new MySqlConnection(bd);
//                con.Open();
//                string req1 = "delete from utilisateur where code='" + code + "'";
//                string req = "insert into indexe_util values ('" + util.Get_code() + "','" + util.Get_nom() + "','" + util.Get_prenom() + "','" + util.Get_pseudo() + "','" + util.Get_motdepasse() + "','" + util.Get_droitacces() + "','" + util.Get_etatcompte() + "','" + date + "')";
//                cmd = new MySqlCommand(req, con);
//                cmd1 = new MySqlCommand(req1, con);
//                resu = cmd1.ExecuteNonQuery();
//                cmd.ExecuteNonQuery();
//                if (resu == 0)
//                {
//                    Console.WriteLine("Suppression Echoue");
//                }
//                else
//                {
//                    Console.WriteLine("Utilisateur supprimer avec succes");
//                }

//                con.Close();

//            }
//            catch (MySqlException e)
//            {
//                Console.WriteLine("message" + e);
//            }






//        }


//        //Blocutilisateur
//        public Boolean BlocUtilisateur(string code, string etatcompte)
//        {



//            Boolean repons = false;

//            string chaine = "Server=localhost;Database=gestion_codevi;Uid=root;Pwd=";
//            MySqlCommand cmd = null; ;
//            MySqlConnection con = null;
//            int verif = 0;

//            string requet = "update utilisateur set etatcompte='" + etatcompte + "' where code='" + code + "'";
//            try
//            {

//                con = new MySqlConnection(chaine);
//                con.Open();
//                cmd = new MySqlCommand(requet, con);
//                verif = cmd.ExecuteNonQuery();
//                if (verif != 0)
//                {


//                    repons = true;

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


//            return repons;


//        }


//    }
//}
