using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.ProjetCodevi.Domaine;
using Com.ProjetCodevi.Dal;
namespace Com.ProjetCodevi.Controleur
{
    public class ClientControleur : MarshalByRefObject, Interface.InterfaceClient
    {
        public static ClientDal clidal = new ClientDal();
        public static Client Ef;

        public void modifierNumeroClient(string Id) { Ef.setnumclient(Id); }
        public void modifierNom(string nom) { Ef.setnom(nom); }
        public void modifierPrenom(string prenom) { Ef.setprenom(prenom); }
        public void modifierSexe(string Sexe) { Ef.setsexe(Sexe); }
        public void modifierAdresse(string adre) { Ef.setadresse(adre); }
        public void modifierTelephone(string tel) { Ef.settelephone(tel); }
        public void modifierCin(string cin) { Ef.setcin(cin); }
        public void modifieremail(string email) { Ef.setemail(email); }

        //Les accesseurs (Methode GET)
        public string RecupererNumeroClient() { return Ef.getnumclient(); }
        public string RecupererNom() { return Ef.getnom(); }
        public string RecupererPrenom() { return Ef.getprenom(); }
        public string RecupererSexe() { return Ef.getsexe(); }
        public string RecupererAdresses() { return Ef.getadresse(); }
        public string RecupererTelephone() { return Ef.gettelephone(); }
        public string RecupererCin() { return Ef.getcin(); }
        public string RecupererEmail() { return Ef.getemail(); }




        public  int EnregistrerrClient(string id, string nom, string pre, string sexe, string adresse,string tel, string cin,string email)
        {
            int resultat = 0;
            Client c1 = null;
            try
            {
            c1 = new Client(id, nom, pre, sexe, adresse,  tel,cin,email);
            resultat = ClientDal.insererclient(c1);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return resultat;
        }

        public  bool Rechercherclient(string code)
        {

            bool trouver = false;
            Ef = new Client();
            Ef = ClientDal.rechercherclient(code);

            try
            {
                if (Ef.getnumclient() != null)
                {
                    trouver = true;
                }
                else
                {
                    trouver = false;
                }
            }
            catch
            {
                trouver = false;
            }
            return trouver;
        }

        public  int Modifier(string id, string nom, string pre, string sexe, string adresse, string tel, string cin, string email)
        {
            int resultat = 0;
           
            try
            {
               Client cl=new Client( id,  nom,  pre,  sexe,  adresse,  tel,  cin,  email);
                resultat = ClientDal.Modifier(cl);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return resultat;
        }

        public  List<Client> Tousclient() {
            List<Client> l = null;
            try {
                l = ClientDal.Tousclient();
            }
            catch (Exception e) {
                throw new Exception(e.Message);
            }
          

            return l;
        }

        public  List<Client> Tousclients(string param)
        {
            List<Client> l = null;
            try
            {
                l = ClientDal.Tousclients(param);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }


            return l;
        }

    }
}
