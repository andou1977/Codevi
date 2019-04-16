//using Com.ProjetCodevi.Domaine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.ProjetCodevi.Interface
{
  public  interface InterfaceClient
    {

    
         void modifierNumeroClient(string Id);
         void modifierNom(string nom);
         void modifierPrenom(string prenom);
         void modifierSexe(string Sexe);
         void modifierAdresse(string adre);
        void modifierTelephone(string tel);
         void modifierCin(string cin);
         void modifieremail(string email);

        //Les accesseurs (Methode GET)
        string RecupererNumeroClient();
        string RecupererNom();
        string RecupererPrenom();
        string RecupererSexe();
        string RecupererAdresses();
        string RecupererTelephone();
        string RecupererCin();
        string RecupererEmail();


        

        int EnregistrerrClient(string id, string nom, string pre, string sexe, string adresse, string tel, string cin, string email);

        bool Rechercherclient(string code);

        int Modifier(string id, string nom, string pre, string sexe, string adresse, string tel, string cin, string email);

        //List<Client> Tousclient();

        //List<Client> Tousclients(string param);

    }
}
