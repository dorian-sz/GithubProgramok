using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homerseklet
{
    class Program
    {
        static void Main(string[] args)
        {
            Months winter = new Months(-15, 10);

            winter.fillList();
            foreach (var item in winter.getTemperature())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Max temp: {0}", winter.getMaxTemp());
            Console.WriteLine("Min temp: {0}", winter.getMinTemp());

            Console.ReadKey();

        }
    }
}
