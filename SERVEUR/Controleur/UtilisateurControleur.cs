using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using Com.ProjetCodevi.Domaine;
using Com.ProjetCodevi.Dal;
using Com.ProjetCodevi.Interface;

namespace Com.ProjetCodevi.Controleur
{
    public class UtilisateurControleur : MarshalByRefObject, Interface.InterfaceUtilisateur
    {

        public Utilisateur Ef;

        public void modifierCode(string Id) { Ef.Set_code(Id); }
        public void modifierNom(string nom) { Ef.Set_nom(nom); }
        public void modifierPrenom(string Prenom) { Ef.Set_prenom(Prenom); }
        public void modifierPseudo(string pseudo) { Ef.Set_pseudo(pseudo); }
        public void modifierMotdepasse(string mot) { Ef.Set_motdepasse(mot); }
        public void modifierDroitdacces(string droit) { Ef.Set_droitacces(droit); }
        public void modifierEtat(string etat) { Ef.Set_etatcompte(etat); }
        public void modifierDate(string date) { Ef.Set_date(date); }


        //Les accesseurs (Methode GET)
        public string RecupererCode() { return Ef.Get_code(); }
        public string RecupererNom() { return Ef.Get_nom(); }
        public string RecupererPrenom() { return Ef.Get_prenom(); }
        public string RecupererPseudo() { return Ef.Get_pseudo(); }
        public string RecupererMotdepasse() { return Ef.Get_motdepasse(); }
        public string RecupererDroitdacces() { return Ef.Get_droitacces(); }
        public string RecupererEtat() { return Ef.Get_etatcompte(); }
        public string RecupererDate() { return Ef.Get_date(); }




        public bool connexion(string id, string mod)
        {
            bool trouver = false;

            Ef = UtilisateurDal.connexion(id, mod);

            try
            {
                if (Ef.Get_code() != null)
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


       public  int AjouterUtilisateur(Utilisateur ut) {


           int resultat = 0;

           try
           {

               resultat = UtilisateurDal.AjouterUtilisateur(ut);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
           return resultat;
       }


       public bool RechercherUtilisateur(string id)
       {
           bool trouver = false;

           Ef = UtilisateurDal.RechercherUtilisateur(id);

           try
           {
               if (Ef.Get_code() != null)
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


       public bool RechercherPseudo(string id,string mod)
       {
           bool trouver = false;

           Ef = UtilisateurDal.RechercherPseudo(id,mod);

           try
           {
               if (Ef.Get_code() != null)
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

       public bool RechercherPseudoModpas(string id, string mod)
       {
           bool trouver = false;

           Ef = UtilisateurDal.RechercherPseudoModpas(id, mod);

           try
           {
               if (Ef.Get_code() != null)
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


       public  int ModifierUtilisateur(string code, string nom, string prenom, string pseudo, string motdepasse, string droit, string etat)
       {
           int resultat = 0;

           try
           {

               resultat = UtilisateurDal.ModifierUtilisateur(code,nom,prenom,pseudo,motdepasse,droit,etat);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
           return resultat;
       }

       public  List<Utilisateur> listerutilisateuractif()
       {
           List<Utilisateur> l = null;
           
           try
           {
               l = UtilisateurDal.listerutilisateuractif();
           }
           catch (Exception e)
           {
               throw new Exception(e.Message);
           }


           return l;
       }

       public  List<Utilisateur> listerutilisateurinactif()
       {
           List<Utilisateur> l = null;
           try
           {
               l = UtilisateurDal.listerutilisateurinactif();
           }
           catch (Exception e)
           {
               throw new Exception(e.Message);
           }


           return l;
       }

       public  int ModifierSonCompte(string code, string pseudo, string motdepasse)
       {
           int resultat = 0;

           try
           {

               resultat = UtilisateurDal.ModifierSonCompte(code, pseudo,  motdepasse);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
           return resultat;
       }


       public string RetracerOperation(string nomuser, string operation, string adressemac)
       {
           string resultat = null;

           try
           {

               resultat = UtilisateurDal.retracerOperation(nomuser, operation, adressemac);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
           return resultat;
       }

       public Boolean BlocUtilisateur(string code, string etatcompte) {

           Boolean reponse = false;
           try
           {
               reponse = UtilisateurDal.BlocUtilisateur(code, etatcompte);
           }
           catch (Exception ex) {
               throw new Exception(ex.Message);
           }
           return reponse;
       }
   }
}
