using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BaratLapoz
{
    class BaratRekord
    {
        private string[,] baratRekord;

        public BaratRekord(string file)
        {
            this.baratRekord = new string[File.ReadLines(file).Count(), 4];
        }

        public void readFile(string file)
        {
            int count = 0;
            foreach (string line in File.ReadLines(file))
            {
                for (int i = 0; i < line.Split(',').Length; i++)
                {
                    this.baratRekord[count, i] = line.Split(',')[i];
                }
                Console.WriteLine("{0}. rekord beolvasva.", count + 1);
                count++;
            }
            Console.WriteLine("Olvasás befejezve.\n");
        }

        public void outFile()
        {
            Console.WriteLine("{0} {1,5} {2,25} {3,10} {4,15}\n", "Rekord", "Név", "Születési Dátum", "Nem", "Bulizás");
            for (int i = 0; i < this.baratRekord.GetLength(0); i++)
            {
                Console.Write("{0} {1,14} {2,16} {3,17} {4,10}\n\n", i + 1, this.baratRekord[i, 0], this.baratRekord[i, 1], this.baratRekord[i, 2], this.baratRekord[i, 3]);

            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adja meg a fájl nevét.");
            string filename = Console.ReadLine();
            BaratRekord br = new BaratRekord(@"C:\Users\2021302\Source\Repos\dorian-sz\GithubProgramok\BaratLapoz\" + filename + ".txt");

            br.readFile(@"C:\Users\2021302\Source\Repos\dorian-sz\GithubProgramok\Rekordok\" + filename + ".txt");
            br.outFile();

            Console.ReadKey();
        }
    }
}
