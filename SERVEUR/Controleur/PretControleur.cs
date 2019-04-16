using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.ProjetCodevi.Domaine;
using Com.ProjetCodevi.Dal;
namespace Com.ProjetCodevi.Controleur
{
    public class PretControleur : MarshalByRefObject, Interface.InterfacePret
    {
      public Pret Ef;

      public void modifierNumeroClient(string Id) { Ef.setNumeroclient(Id); }
      public void modifierNumeroCompte(string id) { Ef.setNumero(id); }
      public void modifierDevise(string devise) { Ef.setdevise(devise); }
      public void modifierDateremboursement(string daterem) { Ef.setdateremboursement(daterem); }
      public void modifierDatepret(string datepret) { Ef.setdatepret(datepret); }
      public void modifierDateremise(DateTime dateremise) { Ef.setdateremise(dateremise); }
      public void modifierMontant(float montant) { Ef.setMontant(montant); }
      public void modifierUtilisateur(string utilisateur) { Ef.setUtilisateur(utilisateur); }


      //Les accesseurs (Methode GET)
      public string RecupererNumeroClient() { return Ef.getNumeroclient(); }
      public string RecupererNumeroCompte() { return Ef.getNumero(); }
      public string RecupererDevise() { return Ef.getDevise(); }
      public string RecupererDateremboursement() { return Ef.getDatremboursement(); }
      public string RecupererDatepret() { return Ef.getDatepret(); }
      public DateTime Dateremise() { return Ef.getDatremiset(); }
      public float RecupererMontant() { return Ef.getmontant(); }
      public string RecupererUtilisateur() { return Ef.getUtilisateur(); }




        public Pret Rechercher(string code)
        {

            Pret e = new Pret();

            try
            {
                e = PretDal.Rechercher(code);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return e;
        }

        public Pret Remboursement(string code)
        {

            Pret e = new Pret();

            try
            {
                e = PretDal.Remboursement(code);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return e;
        }

        public  string rembourserdette(string codecompte, float montant) {
            string resultat = null;

            try
            {

                resultat = PretDal.rembourserdette(codecompte, montant);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return resultat;
        }

        public static Pret RechercherPret(string code)
        {
            Pret e = new Pret();

            try
            {
                e = PretDal.RechercherPret(code);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return e;
        }

        public static Pret RechercherParmois(string code)
        {
            Pret e = new Pret();

            try
            {
                e = PretDal.RechercherParmois(code);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return e;
        }

        public static Pret RechercherPretarembourser(string code)
        {
            Pret e = new Pret();

            try
            {
                e = PretDal.RechercherPretarembourser(code);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return e;
        }

        public static Pret RechercherPretClient(string code)
        {
            Pret e = new Pret();

            try
            {
                e = PretDal.RechercherPretclient(code);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return e;
        }

        public static int Modifierpret(string numerocompte, float reste)
        {
            int resultat = 0;

            try
            {

                resultat = PretDal.Modifierpret(numerocompte, reste);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return resultat;
        }

        public static List<Pret> Touspret()
        {
            List<Pret> l = null;
            try
            {
                l = PretDal.TousPret();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }


            return l;
        }

        public static List<Pret> TouspretCritere(string critere)
        {
            List<Pret> l = null;
            try
            {
                l = PretDal.TousPretcritere(critere);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }


            return l;
        }

        public  string Pret(string codecompte, string codecl, float pret, string devise, string datepret, string dateremise)
        {
            string resultat = null;

            try
            {

                resultat = PretDal.Pret(codecompte, codecl,pret,devise,datepret,dateremise);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return resultat;
        }

        public  string parmois(string codecompte, float pret) {
            string resultat = null;

            try
            {

                resultat = PretDal.parmois(codecompte, pret);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return resultat;
        }

        public string PretPourRemboursement(string codecompte, string codecl, float pret, string devise, string datepret, string dateremise)
        {
            string resultat = null;

            try
            {

                resultat = PretDal.prepourremboursement(codecompte, codecl, pret, devise, datepret, dateremise);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return resultat;
        }

        public static void effacerPret(string numero)
        {
            try {

                PretDal.effacerPret(numero);
            }
            catch (Exception ec) {
                throw new Exception(ec.Message);
            }
        }

        public static void effacerPretarembourser(string numero)
        {
            try
            {

                PretDal.effacerPretarembourser(numero);
            }
            catch (Exception ec)
            {
                throw new Exception(ec.Message);
            }
        }

        public static void effacerParmois(string numero)
        {
            try
            {

                PretDal.effacerparmois(numero);
            }
            catch (Exception ec)
            {
                throw new Exception(ec.Message);
            }
        }

        public static Pret RechercherClient(string code)
        {
            Pret e = new Pret();

            try
            {
                e = PretDal.RechercherClient(code);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return e;
        }

        public static void indexe(string numero, float apayer, string devise, string d, string d1, string utilisateur)
        {
            try
            {

                PretDal.indexe(numero,apayer,devise,d,d1,utilisateur);
            }
            catch (Exception ec)
            {
                throw new Exception(ec.Message);
            }
        }


        public static void EnregistrerTransaction(string numero, string description, float montant, DateTime date_transaction, string utilisateur)
        {
            try
            {

                PretDal.EnregistrerTransaction(numero, description, montant, date_transaction, utilisateur);
            }
            catch (Exception ec)
            {
                throw new Exception(ec.Message);
            }
        }
    }
}
