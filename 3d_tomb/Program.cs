using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3d_tomb
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] tomb = new int[10, 10, 2];

            tomb[0, 0, 0] = 1;
            tomb[0, 0, 1] = 2;

            for (int i = 0; i < tomb.GetLength(0); i++)
            {
               
                for (int j = 0; j < tomb.GetLength(1); j++)
                {
                    for (int k = 0; k < tomb.GetLength(2); k++)
                    {
                        Console.Write("{0} ",tomb[i, j, k]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }

    }
}
