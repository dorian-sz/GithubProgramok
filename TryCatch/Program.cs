using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            Console.WriteLine("Adjon meg egy számt.");
            while (repeat)
            {
                try
                {
                    int num = Int32.Parse(Console.ReadLine());
                    repeat = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Számot adjon meg.");
                    repeat = true;
                }
            }



            Console.ReadKey();
        }
    }
}
