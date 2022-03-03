using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csempemennyiseg2
{
    class Program
    {
        static double Csempemennyiseg(double m, double sz)
        {
            double eredmeny = (m * sz) / (0.2 * 0.2);
            return eredmeny + (eredmeny * 0.1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Csempemennyiseg(Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine())));
            Console.ReadKey();
        }
    }
}
