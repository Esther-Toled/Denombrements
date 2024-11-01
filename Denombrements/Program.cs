using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denombrements
{
    class Program
    {
        static int ensemble(string message)
        {
            Console.Write(message); // le nombre d'éléments à gérer
            int e = int.Parse(Console.ReadLine()); // saisir le nombre
            return e;
        }
        static long calcul(int n)
        {
            long r = 1;
            for (int k = 1; k <= n; k++)
                r *= k;
            return r;
        }
        static long calculR(int t, int n)
        {
            long r = 1;
            for (int k = (t - n + 1); k <= t; k++)
                r *= k;
            //Console.WriteLine("résultat = " + (r1 / r2));
            return r;
        }
        static void Main(string[] args)
        {
            int c = 1, n, t;
            long r;
            while (c != 0)
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                c = int.Parse(Console.ReadLine());

                if (c == 0) { Environment.Exit(0); }

                if (c == 1)
                {
                    //choix de l'ensemble
                    n = ensemble("nombre total d'éléments à gérer = ");
                    // calcul de r
                    r = calcul(n);
                    Console.WriteLine(n + "! = " + r);
                }
                else
                {
                    if (c == 2)
                    {
                        t = ensemble("nombre total d'éléments à gérer = ");
                        n = ensemble("nombre total de sous elements à gerer = ");
                        // calcul de r

                        r = calculR(t, n);
                        //Console.WriteLine("résultat = " + (r1 / r2));
                        Console.WriteLine("A(" + t + "/" + n + ") = " + r);
                    }
                    else
                    {
                        t = ensemble("nombre total d'éléments à gérer = ");
                        n = ensemble("nombre total de sous elements à gerer = ");
                        // calcul de r1
                        long r1 = calculR(t, n);
                        long r2 = 1;
                        for (int k = 1; k <= n; k++)
                            r2 *= k;
                        // calcul de r3
                        //Console.WriteLine("résultat = " + (r1 / r2));
                        Console.WriteLine("C(" + t + "/" + n + ") = " + (r1 / r2));
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
