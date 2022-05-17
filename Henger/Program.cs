using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Henger
{
    class Program
    {
        static void Main(string[] args)
        {
            Hengerclass h = new Hengerclass();

            h.setSugar();
            h.setMagas();

            Console.WriteLine(h.getKerulet());
            Console.WriteLine(h.getTerulet());
            Console.WriteLine(h.getFelszin());
            Console.WriteLine(h.getTerfogat());


            Console.ReadKey();
        }
    }
}
