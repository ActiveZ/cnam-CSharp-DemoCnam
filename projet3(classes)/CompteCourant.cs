using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet3_classes_
{
    class CompteCourant : Compte
    {
        public int MontantDecouvert { get; set; }
    
        public CompteCourant (Client client, int montantDecouvert):
            base(client)
        {
            this.MontantDecouvert = montantDecouvert;
        }

        public new bool Debiter(double montant)
        {
            if (montant <= Solde + MontantDecouvert)
            {
                Solde -= montant;
                AjouterOperation(Toperation.débit, montant);
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return base.ToString() + "découvert autorisé: " + MontantDecouvert + "\n";
        }
    }
}
