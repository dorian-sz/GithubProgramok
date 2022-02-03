using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szorzotabla
{
    class Program
    {
        static int[] Szorzotabla(int num1, int num2)
        {
            int[] szorzotabla = new int[num2];

            for (int i = 0; i < num2; i++)
            {
                szorzotabla[i] = (i + 1) * num1;
            }
            return szorzotabla;
        }
        static void Main(string[] args)
        {
            foreach (var item in Szorzotabla(9, 12))
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadLine();
        }
    }
}
