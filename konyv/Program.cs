using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konyv
{

    class Program
    {
        static bool Terjedelem(int x)
        {
            if (x > 150)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg a könyv címét!");
            string cime = Console.ReadLine();

            while (!String.IsNullOrEmpty(cime))
            {
                Console.WriteLine("Add meg az oldalainak a számát");
                int oldalak = Int32.Parse(Console.ReadLine());
                if (Terjedelem(oldalak))
                {
                    Console.WriteLine("A {0} hosszú terjedelmű könyv", cime);
                }
                else
                {
                    Console.WriteLine("A {0} rövid terjedelmű könyv", cime);
                }
                Console.WriteLine("Add meg a könyv címét!");
                cime = Console.ReadLine();
            }

            Console.ReadKey();

        }
    }
}
