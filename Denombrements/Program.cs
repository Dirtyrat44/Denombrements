/**
* titre : Dénombrements
* description : Application mathématiques pour tester des connaissance sur les dénombrements
* auteur : DirtyRat
* date création : 02/11/2023
* date dernière modification : 02/11/2023
*/
using System;

namespace Denombrements
{
    class Program
    {
        /// <summary>
        /// Fonction main
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            bool quitter = false;
            long r = 1, r1 = 1, r2 = 1;
            // boucle du menu
            while (!quitter)
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                int choix = int.Parse(Console.ReadLine());
                //menu
                switch (choix)
                {
                    case 1:
                        Console.Write("nombre total d'éléments à gérer = ");
                        int n = int.Parse(Console.ReadLine());
                        for (int k = 1; k <= n; k++)
                        {
                            r *= k;
                        }
                        Console.WriteLine(n + "! = " + r);
                        break;
                    case 2:
                        Console.Write("nombre total d'éléments à gérer = ");
                        int t = int.Parse(Console.ReadLine());
                        Console.Write("nombre d'éléments dans le sous ensemble = ");
                        n = int.Parse(Console.ReadLine());
                        for (int k = (t - n + 1); k <= t; k++)
                        {
                            r *= k;
                        }
                        Console.WriteLine("A(" + t + "/" + n + ") = " + r);
                        break;
                    case 3:
                        Console.Write("nombre total d'éléments à gérer = ");
                        t = int.Parse(Console.ReadLine());
                        Console.Write("nombre d'éléments dans le sous ensemble = ");
                        n = int.Parse(Console.ReadLine());
                        for (int k = (t - n + 1); k <= t; k++)
                        {
                            r1 *= k;
                        }
                        for (int k = 1; k <= n; k++)
                        {
                            r2 *= k;
                        }
                        Console.WriteLine("C(" + t + "/" + n + ") = " + (r1 / r2));
                        break;
                    case 0:
                        quitter = true;
                        break;
                }
            }
        }
    }
}


