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
            Henger h = new Henger();

            h.setMagas();
            h.setSugar();

            Console.WriteLine(h.getKerulet());
            Console.WriteLine(h.getTerulet());
            Console.WriteLine(h.getFelszin());
            Console.WriteLine(h.getTerfogat());


            Console.ReadKey();
        }
    }
}
