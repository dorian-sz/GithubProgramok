using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szamrendszer
{

    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            while (repeat)
	        {

                Console.WriteLine("Adja meg a számot.");
                SzamrendszerValto szam = new SzamrendszerValto(Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine("\nVálasszon a menüből.\n\n1. Bináris Számolás\n2. Octális Számolás\n3. Hexadecimális Számolás\n4. Kilép");
                int valasztas = Convert.ToInt32(Console.ReadLine());
                switch (valasztas)
	            {
		            case 1:
                        Console.WriteLine("Bináris Érték: {0}\n", szam.BinarisSzamolas());
                        break;

		            case 2:
                        Console.WriteLine("Octális Érték: {0}\n", szam.Octal());
                        break;
                    case 3:
                        Console.WriteLine("Hexadecimális Érték: {0}\n", szam.Hex());
                        break;
                    case 4:
                        repeat = false;
                        break;
	            }
	        }
            

            
            Console.ReadKey();
        }
    }
}
