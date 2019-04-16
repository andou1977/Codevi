//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Com.ProjetCodevi.Domaine;
//using Com.ProjetCodevi.Dal;
//namespace Com.ProjetCodevi.Controleur
//{
//    public class ClientControleur
//    {

//        public Client Ef;

//        public void modifierNumeroClient(string Id) { Ef.setnumclient(Id); }
//        public void modifierNom(string nom) { Ef.setnom(nom); }
//        public void modifierPrenom(string prenom) { Ef.setprenom(prenom); }
//        public void modifierSexe(string Sexe) { Ef.setsexe(Sexe); }
//        public void modifierAdresse(string adre) { Ef.setadresse(adre); }
//        public void modifierTelephone(string tel) { Ef.settelephone(tel); }
//        public void modifierCin(string cin) { Ef.setcin(cin); }
//        public void modifieremail(string email) { Ef.setemail(email); }

//        //Les accesseurs (Methode GET)
//        public string RecupererNumeroClient() { return Ef.getnumclient(); }
//        public string RecupererNom() { return Ef.getnom(); }
//        public string RecupererPrenom() { return Ef.getprenom(); }
//        public string RecupererSexe() { return Ef.getsexe(); }
//        public string RecupererAdresses() { return Ef.getadresse(); }
//        public string RecupererTelephone() { return Ef.gettelephone(); }
//        public string RecupererCin() { return Ef.getcin(); }
//        public string RecupererEmail() { return Ef.getemail(); }




//        public static int EnregistrerrClient(string id, string nom, string pre, string sexe, string adresse,string tel, string cin,string email)
//        {
//            int resultat = 0;
//            Client c1 = null;
//            try
//            {
//            c1 = new Client(id, nom, pre, sexe, adresse,  tel,cin,email);
//            resultat = ClientDal.insererclient(c1);
//            }
//            catch (Exception ex)
//            {
//                throw new Exception(ex.Message);
//            }
//            return resultat;
//        }

//        public static Client Rechercherclient(string code)
//        {
//            Client e = new Client();

//            try
//            {
//                e = ClientDal.rechercherclient(code);
//            }
//            catch (Exception ex)
//            {
//                throw new Exception(ex.Message);
//            }
//            return e;
//        }
    
//        public static int Modifier(Client uti)
//        {
//            int resultat = 0;
           
//            try
//            {
               
//                resultat = ClientDal.Modifier(uti);
//            }
//            catch (Exception ex)
//            {
//                throw new Exception(ex.Message);
//            }
//            return resultat;
//        }

//        public static List<Client> Tousclient() {
//            List<Client> l = null;
//            try {
//                l = ClientDal.Tousclient();
//            }
//            catch (Exception e) {
//                throw new Exception(e.Message);
//            }
          

//            return l;
//        }

//        public static List<Client> Tousclients(string param)
//        {
//            List<Client> l = null;
//            try
//            {
//                l = ClientDal.Tousclients(param);
//            }
//            catch (Exception e)
//            {
//                throw new Exception(e.Message);
//            }


//            return l;
//        }

//    }
//}
