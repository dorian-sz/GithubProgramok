using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szamologep
{
    class Program
    {
        static double Szamologep(string num1, string num2, string op)
        {
            return Convert.ToDouble(new DataTable().Compute(num1 + op + num2, null));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Adja meg az első számot");
            string x = Console.ReadLine();

            Console.WriteLine("Adja meg a műveletet");
            string o = Console.ReadLine();

            Console.WriteLine("Adja meg a második számot");
            string y = Console.ReadLine();

            Console.WriteLine(Szamologep(x, y, o));
            Console.ReadLine();
        }
    }
}
