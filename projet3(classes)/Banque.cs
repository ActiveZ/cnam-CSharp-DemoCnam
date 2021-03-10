using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet3_classes_
{
    
    class Banque
    {
        private int nbCompte;
        private Compte[] ListeCompte { get; set; } = new Compte[100];

        public void CreerCompteCourant(Client client, int montantDecouvert) {
            CompteCourant cc = new CompteCourant(client, montantDecouvert);
            ListeCompte[nbCompte++] = cc;
        }

        public void CreerCompteEpargne(Client client, double capital, double tauxInteret) {
            CompteEpargne ce = new CompteEpargne(client, capital, tauxInteret);
            ListeCompte[nbCompte++] = ce;
        }


        public string GetComptes()
        {
            StringBuilder listing = new StringBuilder("Liste de compte: \n");
            for (int i =0; i < nbCompte; i++)
            {
                listing.AppendLine(ListeCompte[i].ToString());
            }
            return listing.ToString();
        }



    //    public override string ToString()
    //    {
    //        Console.WriteLine("Liste de compte:");

    //        for (int i = 0; i < nbCompte; i++)
    //        {
    //                Console.WriteLine(ListeCompte[i]);
    //        }
    //        return "";
    //    }
    //}
}
