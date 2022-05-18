using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekordok
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adja meg a fájl nevét.");
            string filename = Console.ReadLine();
            BaratRekord br = new BaratRekord(@"C:\Users\2021302\Source\Repos\dorian-sz\GithubProgramok\Rekordok\"+ filename + ".txt");

            br.readFile(@"C:\Users\2021302\Source\Repos\dorian-sz\GithubProgramok\Rekordok\" + filename+".txt");
            br.outFile();

            Console.ReadKey();
        }
    }
}
