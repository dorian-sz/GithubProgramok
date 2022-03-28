using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buborekrendeyes
{
    class Program
    {
        static int[] Bubblesort(int[] x)
        {
            int val;
            bool swapped = true;
            while (swapped)
            {
                swapped = false;
                for (int i = 0; i < x.Length - 1; i++)
                {
                    if (x[i] > x[i + 1])
                    {
                        val = x[i];
                        x[i] = x[i + 1];
                        x[i + 1] = val;
                        swapped = true;
                    }
                    
                }

            }
            return x;
        }
        static void Main(string[] args)
        {
            int[] aList = new int[150000];
            Random randNum = new Random();
            for (int i = 0; i < aList.Length; i++)
            {
                aList[i] = randNum.Next(1, 170000);
            }

            foreach (var item in Bubblesort(aList))
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }
    }
}
