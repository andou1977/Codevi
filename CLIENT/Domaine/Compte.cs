//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Com.ProjetCodevi.Domaine
//{
//  public  class Compte
//    {
//        private string codecompte;
//        private string codeclient;
//        private string devise;
//        private string type;

//        private float solde;
//        private string datecreation;
//        private string etat;

//        public Compte() { }

//        public Compte(string codecompte, string codeclient, string devise, string type, float solde, string datecreation, string etat)
//        {

//            this.codecompte = codecompte;
//            this.codeclient = codeclient;
//            this.devise = devise;
//            this.type = type;
//            this.solde = solde;
//            this.datecreation = datecreation;
//            this.etat = etat;
//        }
//        public void setCodecompte(string codeco)
//        {
//            this.codecompte = codeco;
//        }
//        public void setCodeclient(string codecli)
//        {
//            this.codeclient = codecli;
//        }
//        public void setdevise(string dev)
//        {
//            this.devise = dev;
//        }
//        public void settype(string ty)
//        {
//            this.type = ty;
//        }

//        public void setsolde(float mont)
//        {
//            this.solde = mont;
//        }
//        public void setdatecreation(string datcret)
//        {

//            this.datecreation = datcret;
//        }
//        public void setetat(string et)
//        {
//            this.etat = et;
//        }

//        public string getcodecompte() { return this.codecompte; }
//        public string getcodeclient() { return this.codeclient; }
//        public string getdevise() { return this.devise; }
//        public string gettype() { return this.type; }
//        public float getsolde() { return this.solde; }
//        public string getdatecreation() { return this.datecreation; }
//        public string getetat() { return this.etat; }
//    }
//}
