using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.ProjetCodevi.Domaine;
using Com.ProjetCodevi.Dal;
namespace Com.ProjetCodevi.Controleur
{
    public class CompteControleur : MarshalByRefObject, Interface.InterfaceCompte
    {
     public Compte Ef;

     public void modifierNumeroClient(string Id) { Ef.setCodeclient(Id); }
     public void modifierNumeroCompte(string id) { Ef.setCodecompte(id); }
     public void modifierDevise(string devise) { Ef.setdevise(devise); }
     public void modifierType(string type) { Ef.settype(type); }
     public void modifierDatecreation(string datecreation) { Ef.setdatecreation(datecreation); }
     public void modifierEtat(string etat) { Ef.setetat(etat); }
     public void modifierSolde(float solde) { Ef.setsolde(solde); }
    

     //Les accesseurs (Methode GET)
     public string RecupererNumeroClient() { return Ef.getcodeclient(); }
     public string RecupererNumeroCompte() { return Ef.getcodecompte(); }
     public string RecupererDevise() { return Ef.getdevise(); }
     public string RecupererType() { return Ef.gettype(); }
     public string RecupererDatecreation() { return Ef.getdatecreation(); }
     public string RecupererEtat() { return Ef.getetat(); }
     public float RecupererSolde() { return Ef.getsolde(); }
   

     public string CreerNouveaucompte(string codecompte, string codeclient, string devise, float solde)
     {
         string resul = null;

         try
         {
           resul=  CompteDal.CreerNouveaucompte(codecompte, codeclient, devise, solde);
         }
         catch (Exception ex) {
             throw new Exception(ex.Message);
         }
         return resul;
     }

     public string DesactiverCompte(string codecompte)
     {
         string resul = null;

         try
         {
             resul = CompteDal.DesactiverCompte(codecompte);
         }
         catch (Exception ex)
         {
             throw new Exception(ex.Message);
         }
         return resul;
     }
     public string ActiverCompte(string codecompte)
     {
         string resul = null;

         try
         {
             resul = CompteDal.ActiverCompte(codecompte);
         }
         catch (Exception ex)
         {
             throw new Exception(ex.Message);
         }
         return resul;
     }


     public static string Pret(string codecompte, float pret, string datepret, string dateremise)
     {
         string resul = null;

         try
         {
             resul = CompteDal.Pret(codecompte,pret,datepret,dateremise);
         }
         catch (Exception ex)
         {
             throw new Exception(ex.Message);
         }
         return resul;
     
     }

     public static string Virement(string codecompte1, string codecompte2, float montant, string dattransaction, string utitisteur)
     {
         string resul = null;

         try
         {
             resul = CompteDal.Virement(codecompte1, codecompte2, montant, dattransaction,utitisteur);
         }
         catch (Exception ex)
         {
             throw new Exception(ex.Message);
         }
         return resul;
     }

     public static Compte PretRecherche(string codecompte)
     {

         Compte resul = null;

         try
         {
             resul = CompteDal.PretRecherche(codecompte);
         }
         catch (Exception ex)
         {
             throw new Exception(ex.Message);
         }
         return resul;
     }

     public static Compte RechercherCompte(string codecompte)
     {

         Compte resul = null;

         try
         {
             resul = CompteDal.RechercherCompte(codecompte);
         }
         catch (Exception ex)
         {
             throw new Exception(ex.Message);
         }
         return resul;
     }

     public static Compte RechercherCpcl(string codecompte)
     {

         Compte resul = null;

         try
         {
             resul = CompteDal.RechercherCpCL(codecompte);
         }
         catch (Exception ex)
         {
             throw new Exception(ex.Message);
         }
         return resul;
     }

     public static string ModifierCompte(string codecompte, string devise, string typecompte, float solde)
     {
         string resul = null;

         try
         {
             resul = CompteDal.ModifierCompte(codecompte, devise, typecompte, solde);
         }
         catch (Exception ex)
         {
             throw new Exception(ex.Message);
         }
         return resul;
     
     }

     public static List<Compte> TousCompte()
     {
         List<Compte> l = null;
         try
         {
             l = CompteDal.Touscompte();
         }
         catch (Exception e)
         {
             throw new Exception(e.Message);
         }


         return l;
     }

     public static List<Compte> TousComptec(string parametre)
     {
         List<Compte> l = null;
         try
         {
             l = CompteDal.Touscomptec(parametre);
         }
         catch (Exception e)
         {
             throw new Exception(e.Message);
         }


         return l;
     }

     public static string Depotcompte(string codecompte, float nouvosolde)
     {
         string resul = null;

         try
         {
             resul = CompteDal.Depotcompte(codecompte, nouvosolde);
         }
         catch (Exception ex)
         {
             throw new Exception(ex.Message);
         }
         return resul;
     }

     public static float depotcompte(float a, float b)
     {
         float resul = 0;

         try
         {
             resul = CompteDal.depotcompte(a, b);
         }
         catch (Exception ex)
         {
             throw new Exception(ex.Message);
         }
         return resul;
     }

     public static float retraitcompte(float a, float b)
     {
         float resul = 0;

         try
         {
             resul = CompteDal.retraitcompte(a, b);
         }
         catch (Exception ex)
         {
             throw new Exception(ex.Message);
         }
         return resul;
     }
 }
}
