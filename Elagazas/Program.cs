using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elagazas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Szamok = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < 15; i++)
            {
                Szamok.Add(rnd.Next(10, 100));
            }

            foreach (var item in Szamok)
            {
                if (item%2 == 0)
                {
                    Console.WriteLine("Szám: {0}", item);
                }
            }

            Console.ReadKey();
        }
    }
}
