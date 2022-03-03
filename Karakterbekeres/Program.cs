using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karakterbekeres
{
    class Program
    {
        static void Main(string[] args)
        {
            int ertek = Math.Floor(m * sz / 20 * 20);
            return ertek + ertek * 0.1;
        }
        static int[] Osszeg(int x)
        {
            Console.WriteLine("Adja meg a magasságot és szélességet.");
            int magassag = Int32.Parse(Console.ReadLine());
            int szelesseg = Int32.Parse(Console.ReadLine());

            Console.WriteLine(Csempemennyiseg(magassag,szelesseg));
        }
    }
}
