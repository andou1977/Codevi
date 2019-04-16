//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Com.ProjetCodevi.Domaine
//{
//    public class Client
//    {

//         // declarations des attributs


//        private string numclient;
//        private string nom;
//        private string prenom;
//        private string sexe;
//        private string adresse;
//        private string telephone;
//        private string cin;
//        private string email;



//        //constructeur par defaut
//        public Client() { }

//        //constructeur avec parametre
//        public Client(string numclient, string nom, string prenom, string sexe, string adresse, string telephone, string cin,string email)
//        {

//            this.numclient = numclient;
//            this.nom = nom;
//            this.prenom = prenom;
//            this.sexe = sexe;
//            this.adresse = adresse;
//            this.telephone = telephone;
//            this.cin = cin;
//            this.email = email;

//        }

//        // methode setteurs

//        public void setnumclient(string numclient)
//        {
//            this.numclient = numclient;

//        }

//        public void setnom(string nom)
//        {
//            this.nom = nom;
           

//        }
//        public void setprenom(string prenom)
//        {
//            this.prenom = prenom;

//        }
//        public void setsexe(string sexe)
//        {
//            this.sexe = sexe;

//        }
//        public void setadresse(string adresse)
//        {
//            this.adresse = adresse;

//        }
//        public void settelephone(string telephone)
//        {
//            this.telephone = telephone;

//        }
//        public void setcin(string cin)
//        {
//            this.cin = cin;

//        }
//        public void setemail(string email)
//        {
//            this.email = email;

//        }

//        //methode getteurs
//        public string getnumclient()
//        {
//            return this.numclient;

//        }
//        public string getnom()
//        {
//            return this.nom;

//        }
//        public string getprenom()
//        {
//            return this.prenom;

//        }
//        public string getsexe()
//        {
//            return this.sexe;

//        }
//        public string getadresse()
//        {
//            return this.adresse;

//        }
//        public string gettelephone()
//        {
//            return this.telephone;

//        }

//        public string getcin()
//        {
//            return this.cin;
//        }
//        public string getemail()
//        {
//            return this.email;
//        }
//    }
//}
