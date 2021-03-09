using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet3_classes_
{
    static class Transaction
    {
        public static bool Virement(Compte source, Compte cible, float montant)
        {
            if (source.Debiter(montant))
            {
                cible.Crediter(montant);
                return true;
            }
            else return false;
        }
    }
}
