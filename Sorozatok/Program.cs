using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorozatok
{
    class Program
    {
        static string Sorozat(double[] szamok)
        {
            double d = szamok[1] - szamok[0];
            int c = 0;

            for (int i = 0; i < szamok.Length - 1; i++)
            {
                if (szamok[i+1] - szamok[i] == d)
                {
                    c++;
                }
            }
            if (c == szamok.Length-1)
            {
                return "Ez egy számtani sorozat.";
            }
            else
            {
                
            }
        }
        static void Main(string[] args)
        {
            double[] sorozat = { 1, 0, -1, -2 };
            Console.WriteLine(Sorozat(sorozat));

            Console.ReadKey();
        }
    }
}
