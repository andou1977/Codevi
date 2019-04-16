using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.ProjetCodevi.Domaine
{
   public class Pret
    {
        
        private string numerocompte;
        private string numeroclient;
        private float montant;
        private string devise;
        private string datepre;
        private DateTime dateremis;
        private string dateremboursement;
        private string utilisateur;


        public Pret() { }

        public Pret(string numero, string numeroclient, float mont,string devise, string datep, DateTime daterem)
        {
            this.numerocompte = numero;
            this.montant = mont;
            this.datepre = datep;
            this.dateremis = daterem;
            this.numeroclient = numeroclient;
            this.devise = devise;
        }
        public Pret(string numero, string numeroclient, float mont,string devise, string datep, DateTime daterem, string dateremb, string utilisateur)
        {
            this.numerocompte = numero;
            this.numeroclient = numeroclient;
            this.montant = mont;
            this.datepre = datep;
            this.dateremis = daterem;
            this.dateremboursement = dateremb;
            this.utilisateur = utilisateur;
            this.devise = devise;
        }
        public Pret(string numero, string numeroclient, float mont,string devise, string datep, DateTime daterem, string utilisateur)
        {
            this.numerocompte = numero;
            this.numeroclient = numeroclient;
            this.montant = mont;
            this.datepre = datep;
            this.dateremis = daterem;
            this.utilisateur = utilisateur;
            this.devise = devise;
        }
        public Pret(string numero,float mont)
        {
            this.numerocompte = numero;
         
            this.montant = mont;
            

        }

        public void setNumero(string num)
        {
            this.numerocompte = num;
        }
        public void setNumeroclient(string num)
        {
            this.numerocompte = num;
        }
        public void setMontant(float mont)
        {
            this.montant = mont;
        }
        public void setdatepret(string datp)
        {
            this.datepre = datp;
        }
        public void setdateremise(DateTime daterem)
        {
            this.dateremis = daterem;
        }
        public void setdevise(string devise)
        {
            this.devise = devise;
        }
        public void setdateremboursement(string dateremb)
        {
            this.dateremboursement = dateremb;
        }
        public void setUtilisateur(string util)
        {
            this.utilisateur = util;
        }
        public string getNumero()
        {
            return this.numerocompte;
        }
        public string getNumeroclient()
        {
            return this.numeroclient;
        }
        public float getmontant()
        {
            return this.montant;
        }
        public string getDevise()
        {
            return this.devise;
        }
        public string getDatepret()
        {
            return this.datepre;
        }
        public DateTime getDatremiset()
        {
            return this.dateremis;
        }
        public string getDatremboursement()
        {
            return this.dateremboursement;
        }
        public string getUtilisateur()
        {
            return this.utilisateur;
        }
    }
}
