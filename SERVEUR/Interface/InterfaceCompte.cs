using Com.ProjetCodevi.Domaine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.ProjetCodevi.Interface
{
   public interface InterfaceCompte
    {

        void modifierNumeroClient(string Id);
        void modifierNumeroCompte(string id);
        void modifierDevise(string devise);
        void modifierType(string type);
        void modifierDatecreation(string datecreation);
        void modifierEtat(string etat);
        void modifierSolde(float solde);


        //Les accesseurs (Methode GET)
        string RecupererNumeroClient();
         string RecupererNumeroCompte();
          string RecupererDevise();
          string RecupererType();
          string RecupererDatecreation();
          string RecupererEtat();
          float RecupererSolde();


           string CreerNouveaucompte(string codecompte, string codeclient, string devise, float solde);

           string DesactiverCompte(string codecompte);
           string ActiverCompte(string codecompte);


           string Pret(string codecompte, float pret, string datepret, string dateremise);

           string Virement(string codecompte1, string codecompte2, float montant, string dattransaction, string utitisteur);

           Compte PretRecherche(string codecompte);

           Compte RechercherCompte(string codecompte);

           Compte RechercherCpcl(string codecompte);

           string ModifierCompte(string codecompte, string devise, string typecompte, float solde);

           List<Compte> TousCompte();

           List<Compte> TousComptec(string parametre);

           string Depotcompte(string codecompte, float nouvosolde);

           float depotcompte(float a, float b);

           float retraitcompte(float a, float b);
    }
}
