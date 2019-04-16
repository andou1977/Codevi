using Com.ProjetCodevi.Domaine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.ProjetCodevi.Interface
{
    public interface InterfacePret
    {

        void modifierNumeroClient(string Id);
        void modifierNumeroCompte(string id);
        void modifierDevise(string devise);
        void modifierDateremboursement(string daterem);
        void modifierDatepret(string datepret);
        void modifierDateremise(DateTime dateremise);
        void modifierMontant(float montant);
        void modifierUtilisateur(string utilisateur);


        //Les accesseurs (Methode GET)
        string RecupererNumeroClient();
        string RecupererNumeroCompte();
        string RecupererDevise();
        string RecupererDateremboursement();
        string RecupererDatepret();
        DateTime Dateremise();
        float RecupererMontant();
        string RecupererUtilisateur();




        bool Rechercher(string code);

        bool Remboursement(string code);

        string rembourserdette(string codecompte, float montant);

        bool RechercherPret(string code);

        bool RechercherParmois(string code);

        bool RechercherPretarembourser(string code);

        bool RechercherPretClient(string code);

        int Modifierpret(string numerocompte, float reste);

        List<Pret> Touspret();

        List<Pret> TouspretCritere(string critere);

        string Pret(string codecompte, string codecl, float pret, string devise, string datepret, string dateremise);

        string parmois(string codecompte, float pret);

        string PretPourRemboursement(string codecompte, string codecl, float pret, string devise, string datepret, string dateremise);

        void effacerPret(string numero);

        void effacerPretarembourser(string numero);

        void effacerParmois(string numero);

        bool RechercherClient(string code);

        void indexe(string numero, float apayer, string devise, string d, string d1, string utilisateur);


        void EnregistrerTransaction(string numero, string description, float montant, DateTime date_transaction, string utilisateur);
    }
}
