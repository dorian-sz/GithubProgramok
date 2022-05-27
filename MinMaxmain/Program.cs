using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxmain
{
    class Program
    {
        static void Main(string[] args)
        {
            MinMaxclass mmc = new MinMaxclass(5);

            mmc.userFeltolt();
            mmc.arrSort();
            Console.WriteLine(mmc.getMin());
            Console.WriteLine(mmc.getMax());

            Console.ReadKey();
        }
    }
}
