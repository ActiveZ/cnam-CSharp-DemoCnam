using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet3_classes_
{
    static class Extensions
    {
        public static bool VirementDiffere(this Compte cpt, string dateVirt, float montant)
        {
            return cpt.Debiter(montant);
        }
    }
}
