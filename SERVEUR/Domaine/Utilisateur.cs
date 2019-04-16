using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.ProjetCodevi.Domaine
{
   public class Utilisateur
    {
        private string _code;
        private string _nom;
        private string _prenom;
        private string _pseudo;
        private string _motdepasse;
        private string _droitacces;
        private string _etatcompte;
        private string _date;
        private byte[] _photo;

        //constructeur par default
        public Utilisateur()
        {
        }
        //constructeur avec parametre
        public Utilisateur(string code, string nom, string prenom, string pseudo, string motdepasse, string droitacces, string etatcompte, string date, byte[] photo)
        {
            this._code = code;
            this._nom = nom;
            this._prenom = prenom;
            this._pseudo = pseudo;
            this._motdepasse = motdepasse;
            this._droitacces = droitacces;
            this._etatcompte = etatcompte;
            this._date = date;
            this._photo = photo;
        }

        public Utilisateur(string code, string nom, string prenom, string pseudo, string motdepasse, string droitacces, string etatcompte, string date)
        {
            this._code = code;
            this._nom = nom;
            this._prenom = prenom;
            this._pseudo = pseudo;
            this._motdepasse = motdepasse;
            this._droitacces = droitacces;
            this._etatcompte = etatcompte;
            this._date = date;
        }

        public Utilisateur(string code, string nom, string prenom, string pseudo, string motdepasse, string droitacces, string etatcompte)
        {
            this._code = code;
            this._nom = nom;
            this._prenom = prenom;
            this._pseudo = pseudo;
            this._motdepasse = motdepasse;
            this._droitacces = droitacces;
            this._etatcompte = etatcompte;

        }



        public Utilisateur(string code, string pseudo, string motdepasse)
        {
            this._code = code;

            this._pseudo = pseudo;
            this._motdepasse = motdepasse;


        }
        //mutateur
        public string Get_code()
        {
            return this._code;
        }
        public string Get_nom()
        {
            return this._nom;
        }
        public string Get_prenom()
        {
            return this._prenom;
        }
        public string Get_pseudo()
        {
            return this._pseudo;
        }
        public string Get_motdepasse()
        {
            return this._motdepasse;
        }
        public string Get_droitacces()
        {
            return this._droitacces;
        }
        public string Get_etatcompte()
        {
            return this._etatcompte;
        }
        public string Get_date()
        {
            return this._date;
        }
        public byte[] Get_photo()
        {
            return this._photo;
        }
        //accesseur
        public void Set_code(string code)
        {
            _code = code;
        }
        public void Set_nom(string nom)
        {
            _nom = nom;
        }
        public void Set_prenom(string prenom)
        {
            _prenom = prenom;
        }
        public void Set_pseudo(string pseudo)
        {
            _pseudo = pseudo;
        }
        public void Set_motdepasse(string motdepasse)
        {
            _motdepasse = motdepasse;
        }
        public void Set_droitacces(string droitacces)
        {
            _droitacces = droitacces;
        }
        public void Set_etatcompte(string etatcompte)
        {
            _etatcompte = etatcompte;
        }
        public void Set_date(string date)
        {
            _date = date;
        }
        public void Set_photo(byte[] photo)
        {
            _photo = photo;
        }
    }
}
