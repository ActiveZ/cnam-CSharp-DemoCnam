using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet3_classes_
{
    class CompteEpargne : Compte
    {
        public double TauxInteret { get; set; }
        public DateTime DateCreation { get; init; }
        public double Capital { get; init; }
        public int Duree { get; init; } // durée d'immo du compte

        public CompteEpargne(Client client, double capital = 0, double tauxInteret = 0) :
            base(client)
        {
            this.TauxInteret = tauxInteret;
            this.DateCreation = DateTime.Today;
            this.Capital = capital;
            this.Duree = 4;
        }


        public new void Debiter(double montant)
        {
            if (DateTime.Today >= DateCreation.AddYears(Duree)) base.Debiter(montant);
        }

        private double GetInterets()
        {
            double interets;
            interets = Capital * TauxInteret / 100;
            return interets;
        }

        public override string ToString() => "montant du compte épargne (capital + intérets): " + Capital + " + " + GetInterets() + " = " + (Capital + GetInterets()) + "\n";
    }
}

