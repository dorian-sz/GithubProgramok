using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ntermeszetesszam
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int N = rnd.Next(5,10);
            int szam;
            int paros = 0;
            int paratlan = 0;
            int paratlanOssz = 0;
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Írjon be egy számot:");
                szam = Int32.Parse(Console.ReadLine());

                if (szam % 2 == 0)
                {
                    paros++;
                }
                else
                {
                    paratlan++;
                    paratlanOssz = paratlanOssz + szam;
                      
                }

            }
            Console.WriteLine("Páros számok: {0}, Páratlan számok: {1}, összege: {2}", paros, paratlan, paratlanOssz);

            Console.ReadKey();
        }
    }
}
