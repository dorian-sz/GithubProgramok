using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cimletezes
{
    class Program
    {

        static void Main(string[] args)
        {
            List<int> x = new List<int>();
            double osszeg = double.Parse(Console.ReadLine());
            foreach (var item in Cimlet(Math.Round(osszeg / 5.0) * 5, x))
            {
                Console.WriteLine("Pénz: {0}", item);
            }
            
            Console.ReadKey();

        }
        static List<int> Cimlet(double osszeg, List<int> vissza)
        {
            List<int> ermek = vissza;
            int[] erme = { 20000, 10000, 5000, 2000, 1000, 500, 200, 100, 50, 20, 10, 5 };

            if(osszeg > 0)
            {
                for (int i = 0; i < erme.Length; i++)
			    {

                    if (osszeg - erme[i] >= 0)
                    {
                        ermek.Add(erme[i]);
                        return Cimlet(osszeg - erme[i], ermek);

                    }
			    }
            }
            return  ermek;
        }
    }
}
