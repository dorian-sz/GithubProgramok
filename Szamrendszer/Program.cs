using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szamrendszer
{

    class Program
    {
        static void Main(string[] args)
        {

            SzamrendszerValto szam = new SzamrendszerValto(Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine(szam.Octal());
            Console.WriteLine(szam.BinarisSzamolas());

            Console.ReadKey();
        }
    }
}
