using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szigetek
{
    class Program
    {
        static int[] Szigethossz(string[] x)
        {
            int meret = 0;
            int legnagyobb = 0;

            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] == "1")
                {
                    meret++;

                }
                else
                {
                    if (legnagyobb < meret)
                    {
                        legnagyobb = meret;
                    }
                    meret = 0;

                }

            }
            return {legnagyobb};
        }

        static void Main(string[] args)
        {
            string[] terkep = { "1", "1", "1", "0", "0", "1", "1", "0", "1", "1", "1", "1", "0", "0", "1"};
            int[] eredmeny = Szigethossz(terkep)
            Console.WriteLine("Legnagyobb sziget hossza: {0}", eredmeny[0];
            Console.WriteLine("Hány sziget van: {0}", eredmeny[1];

            Console.ReadKey();

        }
    }
}
