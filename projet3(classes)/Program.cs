using System;

namespace projet3_classes_
{
    class Program
    {
        static void Main(string[] args)
        {
            float montant;

            // création  compte avec constructeur par défaut
            Compte monCompte = new Compte();

            Console.WriteLine(monCompte.ToString());

            // crédit
            montant = 50;
            Console.WriteLine(monCompte.Crediter(montant) ? "Votre compte a été crédité de " + montant + " euros" : "Vous ne pouvez pas créditer un montant négatif");
            Console.WriteLine(monCompte.ToString());

            // débit
            montant = 100;
            Console.WriteLine(monCompte.Debiter(montant) ? "Votre compte a été débité de " + montant + " euros" : "Le débit dépasse le solde du compte");
            Console.WriteLine(monCompte.ToString());

            // création compte 2
            Console.WriteLine("----------------------------------");
            Console.WriteLine("monCompte2");

            // création  compte avec constructeur par défaut
            Compte monCompte2 = new Compte("666", "31/12/1999", 666666);

            Console.WriteLine(monCompte2.ToString());

            // deconstructeur
            Console.WriteLine("----------------------------------");

            (string numero, _, float solde) = monCompte2;
            Console.WriteLine("Deconstructeur compte 2 => date création: " + numero + " - solde: " + solde);

            // virt cpt1 => cpt2
            Console.WriteLine("----------------------------------");
            Console.WriteLine(monCompte.ToString());
            Console.WriteLine(monCompte2.ToString());

            montant = 30;
            Console.WriteLine(Transaction.Virement(monCompte, monCompte2, montant) ? "Virement cpt1 -> cpt2 de " + montant : "Le débit dépasse le solde du compte");

            Console.WriteLine(monCompte.ToString());
            Console.WriteLine(monCompte2.ToString());


            // debit différé
            Console.WriteLine("----------------------------------");
            Console.WriteLine(monCompte.ToString());
            montant = 10;
            Console.WriteLine(monCompte.VirementDiffere("date", montant) ? "Débit différé de " + montant : "Le débit dépasse le solde du compte");
            Console.WriteLine(monCompte.ToString());


            Console.WriteLine("----------------------------------");
            Client client1 = new Client("nom1", "prenom1",new DateTime(1/1/2000) ,"email1", "tel1");
            Console.WriteLine("Client 1: " + client1.ToString());


            Console.WriteLine("----------------------------------");
            Console.WriteLine("Création compte");
        }
    }
}
