using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet3_classes_
{
    class Compte
    {
        // attributs
        private string _numero;
        private DateTime _dateCreation;
        private float _solde;
        private Client _titulaire;

        // constructeur
        public Compte(string numero = "123", string dateCreation = "0/1/2000", float solde = 100)
        {
            _numero = numero;
            _dateCreation = DateTime.Parse (dateCreation);
            _solde = solde;
        }

        public Compte(string numero = "123", DateTime dateCreation = new DateTime(), float solde = 100, Client titulaire = new Client())
        {
            _numero = numero;
            _dateCreation = dateCreation;
            _solde = solde;
            _titulaire = titulaire;
        }

        public Compte()
        {
            _numero = "000";
            _dateCreation = DateTime.Today;
            _solde = 0;
        }

        // getters - setters
        public float Solde
        {
            get => _solde;
        }


        // methodes
        public bool Crediter(float montant)
        {
            if (montant >= 0)
            {
                _solde += montant;
                return true;
            }
            return false;
        }


        public bool Debiter(float montant)
        {
            if (montant < _solde)
            {
                _solde -= montant;
                return true;
            }
            return false;
        }

        
        public override string ToString() => $"Votre compte numéro " + _numero + " créé le " + _dateCreation + " est créditeur de " + _solde + " euros " + "titulaire: " + _titulaire;


        public void Deconstruct(out string numero, out DateTime dateCreation, out float solde)
        {
            numero = _numero;
            dateCreation = _dateCreation;
            solde = _solde;
        }

        public void Titulaire()
        {

        }
    }
}
