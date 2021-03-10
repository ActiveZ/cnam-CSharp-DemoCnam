using System;

namespace projet3_classes_
{
    class Program
    {
        public static void TestCompte()
        {
            Client c1 = new Client("nom1", "prenom1", new DateTime(1991, 06, 02), "nom1@gmail.com", "0202020202");
            Client c2 = new Client("nom2", "prenom2", new DateTime(1991, 06, 02), "nom2@gmail.com", "0202020202");
            Compte cpt1, cpt2;
            cpt1 = new Compte(c1, "101", 500, "2021-03-01");
            cpt2 = new Compte(c2, "102");
            cpt1.Crediter(100000);
            cpt2.Crediter(300);
            if (cpt2.Debiter(500))
                Console.WriteLine("Debit impossible");
            Console.WriteLine(cpt1.Solde);
            Console.WriteLine(cpt2.Solde);

            Transaction.Virement(cpt1, cpt2, 100);
            Console.WriteLine(cpt1.ToString());
            Console.WriteLine(cpt2.ToString());
            cpt1.VirementDiffere("2021-04-01", 100);

            // appel implicite du deconstructeur 
            (string num, _, double solde) = cpt1;
            Console.WriteLine($"Info du compte cpt1 : {num} {solde}");

        }
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
            Compte monCompte2 = new Compte();

            Console.WriteLine(monCompte2.ToString());

            // deconstructeur
            Console.WriteLine("----------------------------------");

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
            Client client1 = new Client("nom1", "prenom1", new DateTime(1 / 1 / 2000), "email1", "tel1");
            Console.WriteLine("Client 1: " + client1.ToString());


            Console.WriteLine("----------------------------------");
            //Compte monCompte3 = new Compte("888", DateTime.Now, 888, client1);
            //monCompte3.ToString();


            TestCompte();


            Console.WriteLine("----------------------------------");
            Console.WriteLine("Création opération");
            montant = 25;
            monCompte.Debiter(montant);
            monCompte.Crediter(montant);
            monCompte.Debiter(montant);
            Console.WriteLine("Affichage historique");
            Console.WriteLine(monCompte.GetHistorique());

            Console.WriteLine("----------------------------------");
            Console.WriteLine("Création compte courant");
            montant = 500;
            CompteCourant cc = new CompteCourant(client1, 100);
            Console.WriteLine("Compte courant " + cc.ToString());

            Console.WriteLine("crédit de " + montant);
            cc.Crediter(montant);
            Console.WriteLine("Compte courant " + cc.ToString());

            Console.WriteLine("débit de " + montant);
            cc.Debiter(montant);
            Console.WriteLine("Compte courant " + cc.ToString());

            montant = 50;
            Console.WriteLine("débit de " + montant);
            cc.Debiter(montant);
            Console.WriteLine("Compte courant " + cc.ToString());

            montant = 200;
            Console.WriteLine("débit de " + montant);
            cc.Debiter(montant);
            Console.WriteLine("Compte courant " + cc.ToString());


            Console.WriteLine("----------------------------------");
            Console.WriteLine("Création compte épargne");
            //Console.WriteLine(client1.ToString());
            montant = 500;
            CompteEpargne ce = new CompteEpargne(client1, montant, 5);
            Console.WriteLine(ce.ToString());
        }
    }
}
