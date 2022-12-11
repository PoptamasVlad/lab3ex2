using System;

namespace lab3ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Scrieti o functie care va determina daca un numar este sau nu numar prim. Apelati-o si afisati-i rezultatul */

            int n = int.Parse(Console.ReadLine());

            if(NumarPrim(n))
            {
                Console.WriteLine(n + " este numar prim");
            }
            else
            {
                Console.WriteLine(n + " nu este numar prim");
            }

            static bool NumarPrim(int n)
            {
                int div = 0;
                for(int i=1; i<=n; i++)
                {
                    if(n % i == 0)
                    {
                        div++;
                    }
                }
                if(div == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
