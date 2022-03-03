using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csempezes
{
    class Program
    {
        static double Csempemennyiseg(int m, int sz)
        {
            int ertek = Math.Floor(m * sz / 20 * 20);
            return ertek + ertek * 0.1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Adja meg a magasságot és szélességet.");
            int magassag = Int32.Parse(Console.ReadLine());
            int szelesseg = Int32.Parse(Console.ReadLine());

            Console.WriteLine(Csempemennyiseg(magassag,szelesseg));
        }
    }
}
