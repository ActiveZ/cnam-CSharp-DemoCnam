using System;

namespace projet2
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = 0, erreur = 0;
            string op, txt = "";
            float a, result = 0;

            Console.Write("Entrez un entier a = ");
            bool ok = float.TryParse(Console.ReadLine(), out a);
            
            do
            {
                Console.Write("Entrez l'opérateur (+ - * / p(puissance)), entrée pour finir: ");
                op = Console.ReadLine();
                if (op != "")
                {
                    Console.Write("Entrez un entier b = ");
                    
                    b = int.Parse(Console.ReadLine());
                }
                var response = Calcul(a, b, op);
                Console.WriteLine(response.erreur != "" ? response.erreur : a + op + b + "=" + response.result);
            } while (op != "");
        }


        static (string erreur, float result) Calcul(float a, float b, string op)
        {
            float result = 0;
            string erreur = (op == "/" && b == 0) ? "Erreur: division par 0 !" : "";

            switch (op)
            {
                case "+":
                    {
                        result = a + b;
                        break;
                    }
                case "-":
                    {
                        result = a - b;
                        break;
                    }
                case "*":
                    {
                        result = a * b;
                        break;
                    }
                case "/":
                    {

                        if (erreur == "") result = a / b;
                        break;
                    }
                case "p":
                    result = 1;
                    if (b>0) for (int i = 0; i < b; i++) result *= a;
                    if (b < 0)
                    {
                        b = -b;
                        for (int i = 0; i < b; i++) result *= a;
                        result = 1 / result;
                    }
                    break;
                case "": break;
                default:
                    {
                        erreur = "ERREUR inconnue !";
                        break;
                    }
            }
            return (erreur, result);
        }
    }

}


/*    switch (op)
    {
        case "+":
            {
                result = a + b;
                break;
            }
        case "-":
            {
                result = a - b;
                break;
            }
        case "*":
            {
                result = a * b;
                break;
            }
        case "/":
            {

                if (b != 0) result = a / b;
                else
                {
                    erreur = 1;
                    Console.WriteLine("ERREUR: division par zero !");
                }
                break;
            }
        case "": break;
        default:
            {
                erreur = 2;
                Console.WriteLine("ERREUR inconnue !");
                break;
            }
    }
    if (erreur == 0 && op != "")
    {
        txt += a + " " + op + " " + b + " = " + result;
        Console.WriteLine(txt);
        txt = "";
        a = result;
    }*/