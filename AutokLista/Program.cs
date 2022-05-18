using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AutokLista
{
    class Program
    {
        static void Main(string[] args)
        {
            Autoclass ac = new Autoclass(@"C:\Users\2021302\Source\Repos\dorian-sz\GithubProgramok\AutokLista\Autok.txt");

            ac.readFile();
            ac.outFile();

            Console.ReadKey();
        }
    }
}
