using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oszthato5el
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Intervallum kezdete:");
            int bekertMin = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Intervallum vége:");
            int bekertMax = Int32.Parse(Console.ReadLine());
            for (int i = bekertMin; i < bekertMax; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine("Osztható 5-el. A szám: {0}", i);
                }

            }
            Console.ReadKey();
        }
    }
}
