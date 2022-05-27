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
        private string filename;
        private int recordNum, prevNum;

        public BaratRekord(string file)
        {
            this.baratRekord = new string[File.ReadLines(file).Count(), 4];
            this.filename = file;
            this.recordNum = 0;
        }

        public void readFile()
        {
            int count = 0;
            foreach (string line in File.ReadLines(this.filename))
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

        public void outFilePgUp()
        {   
                
      
		        if (this.recordNum < this.baratRekord.GetLength(0)-1)
	            {
                    Console.Write("{0,2} {1,14} {2,16} {3,17} {4,10}\n", this.recordNum, this.baratRekord[this.recordNum, 0], this.baratRekord[this.recordNum, 1], this.baratRekord[this.recordNum, 2], this.baratRekord[this.recordNum, 3]);
                    this.recordNum++;
	            }


            
            if (this.recordNum % 20 != 0 && this.recordNum < this.baratRekord.GetLength(0)-1)
	        {
                this.outFilePgUp();
	        }
        }

        public void outFilePgDn()
        {   
            if (this.recordNum > 0)
	        {
                this.recordNum = this.recordNum-20;
                for (int i = 0; i < 20; i++)
			    {
                    Console.Write("{0,2} {1,14} {2,16} {3,17} {4,10}\n", this.recordNum+i, this.baratRekord[this.recordNum+i, 0], this.baratRekord[this.recordNum+i, 1], this.baratRekord[this.recordNum+i, 2], this.baratRekord[this.recordNum+i, 3]);
                
			    }
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
            br.readFile();
            br.outFilePgUp();
            while (true)
	        {
                if (Console.ReadKey().Key == ConsoleKey.PageUp)
	            {
                   Console.Clear();
                   br.outFilePgUp();
	            }
                if (Console.ReadKey().Key == ConsoleKey.PageDown)
	            {
                   Console.Clear();
                   br.outFilePgDn();
	            }
                
	        }

            Console.ReadKey();
        }
    }
}
