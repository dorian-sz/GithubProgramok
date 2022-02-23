using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negativ
{
    class Program
    {
        static string Negativ(int x, int y)
        {
            if (x < 0 & y < 0)
            {
                return "A mind a két szám negatív";
            }
            if (x < 0)
            {
                return "A két szám közül az első negatív";
            }
            if (y < 0)
            {
                return "A két szám közül a második negatív";
            }
            else
            {
                return "A két szám közül egyik sem negatív";
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Adja meg a számokat: ");
            Console.WriteLine(Negativ(Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine())));
            Console.ReadKey();
        }
    }
}
