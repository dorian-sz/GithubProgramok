using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0igbeker
{
    class Program
    {
        static void Main(string[] args)
        {
            var szamok = new List<int>();
            Console.WriteLine("Adjon meg egy számot.");
            int bekert = Int32.Parse(Console.ReadLine());
            
            while (bekert !=0 )
            {
                szamok.Add(bekert);
                Console.WriteLine("Adjon meg egy számot. Ha 0 a program leáll.");
                bekert = Int32.Parse(Console.ReadLine());
                
            }
            szamok.Sort();
            Console.WriteLine("Legnagyobb szám: {0}", szamok[szamok.Count - 1]);

            Console.ReadKey();
        }
    }
}
