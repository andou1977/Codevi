using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.ProjetCodevi.Domaine;
namespace Com.ProjetCodevi.Interface
{
    public interface InterfaceUtilisateur
    {
        void modifierCode(string Id);
        void modifierNom(string nom);
        void modifierPrenom(string Prenom);
        void modifierPseudo(string pseudo);
        void modifierMotdepasse(string mot);
        void modifierDroitdacces(string droit);
        void modifierEtat(string etat);
        void modifierDate(string date);


        //Les accesseurs (Methode GET)
        string RecupererCode();
        string RecupererNom();
        string RecupererPrenom();
        string RecupererPseudo();
        string RecupererMotdepasse();
        string RecupererDroitdacces();
        string RecupererEtat();
        string RecupererDate();




        bool connexion(string pseudo, string modpas);

        int AjouterUtilisateur(Utilisateur ut);

        bool RechercherUtilisateur(string code);

        bool RechercherPseudo(string code, string modpas);

        bool RechercherPseudoModpas(string code, string modpas);

        int ModifierUtilisateur(string code, string nom, string prenom, string pseudo, string motdepasse, string droit, string etat);

        List<Utilisateur> listerutilisateuractif();

        List<Utilisateur> listerutilisateurinactif();

        int ModifierSonCompte(string code, string pseudo, string motdepasse);

        Boolean BlocUtilisateur(string code, string etatcompte);
        string RetracerOperation(string nomuser, string operation, string adressemac);

    }
}
