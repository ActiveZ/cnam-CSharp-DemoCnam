using System;

namespace DemoCnam
{
    class Program
    {
        static void Main(string[] args)
        {
            int essai, cpt = 0;
            Random rnd = new Random();
            
            int x = rnd.Next(1, 21);

            do
            {
                cpt++;
                Console.Write("Entrer votre essai entre 1 et 20: ");
                essai = int.Parse(Console.ReadLine());
                if (essai < x) Console.WriteLine("trop petit");
                if (essai > x) Console.WriteLine ("trop grand");
            } 
            while (essai != x);
            Console.WriteLine("Gagné en "+ cpt + " coups !!!");
        }
    }
}
