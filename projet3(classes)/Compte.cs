using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet3_classes_
{
    class Compte
    {
        #region attributs ( private ) 

        private string _numero;
        private double _solde;
        private DateTime _dateCreation;

        private Client _titulaire;

        private Operation[] _historique = new Operation[10];
        private int nbOp = 0;
        #endregion

        #region proprietes 

        public string Numero
        {
            get => _numero;
        }

        public double Solde
        {
            get => _solde;
            set => _solde = value;
        }

        public DateTime DateCreation
        {
            get => _dateCreation;
        }

        public Client Titulaire
        {
            get => _titulaire;
        }

        #endregion

        #region constructeurs 

        public Compte(Client titulaire, string numero, double solde, string dateCreation)
        {
            _titulaire = titulaire;
            _numero = numero;
            _solde = solde;
            _dateCreation = DateTime.Parse(dateCreation);
        }

        public Compte(Client titulaire, string numero, double solde, DateTime dateCreation)
        {
            _titulaire = titulaire;
            _numero = numero;
            _solde = solde;
            _dateCreation = dateCreation;
        }

        public Compte(Client titulaire, string numero = "555")
        {
            _titulaire = titulaire;
            _numero = numero;
            _solde = 0;
            _dateCreation = DateTime.Now;
        }

        public Compte() : this(new Client(), "indefini", 0, DateTime.Now) { }


        #endregion

        // methodes
        public bool Crediter(double montant)
        {
            if (montant >= 0)
            {
                _solde += montant;
                AjouterOperation(Toperation.crédit, montant);
                return true;
            }
            return false;
        }


        public bool Debiter(double montant)
        {
            if (montant < _solde)
            {
                _solde -= montant;
                AjouterOperation(Toperation.débit, montant);
                return true;
            }
            return false;
        }


        protected void AjouterOperation(Toperation type, double montant)
        {
            Operation op;
            op = new Operation(type, DateTime.Now, montant);
            _historique[nbOp++] = op;
        }

        public string GetHistorique()
        {
            string txt = "";

            for (int i = 0; i < _historique.Length; i++)
            {
                Console.WriteLine(_historique[i]);
            }
            return txt;
        }

        public override string ToString() => $"Votre compte numéro " + _numero + " créé le " + _dateCreation + " solde: " + _solde + " euros " + "titulaire: " + _titulaire + "\n";


        public void Deconstruct(out string numero, out DateTime dateCreation, out double solde)
        {
            numero = _numero;
            dateCreation = _dateCreation;
            solde = _solde;
        }

    }
}
