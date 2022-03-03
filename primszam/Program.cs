using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primszam
{
    class Program
    {
        static List<int> Prim(int x, List<int> Primek)
        {
            int counter = 0;
            if (Primek.Count <= 499)
            {
                for (int i = 1; i < x + 1; i++)
                {
                    if (x % i == 0)
                    {
                        counter++;
                    }
                }
                if (counter == 2)
                {
                    Primek.Add(x);
                }

                return Prim(x + 1, Primek);

            }

            return Primek;

            
        }
        static void Main(string[] args)
        {
            List<int> Primek = new List<int>();
            Console.WriteLine(Prim(2, Primek).Sum());


            Console.ReadKey();
        }
    }
}
