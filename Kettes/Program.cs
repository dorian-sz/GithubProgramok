using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kettes
{
    class KettesSzamrendszer
    {
        private int tizesSzam;
        private string binaris;
        private int[] Szamok;

        public KettesSzamrendszer(int tizesSzam)
        {
            this.binaris = "";
            this.tizesSzam = tizesSzam;
            this.Szamok = new int[] { 128, 64, 32, 16, 8, 4, 2, 1 };
        }

        public void Szamolas()
        {
            for (int i = 0; i < this.Szamok.Length; i++)
            {
                if (this.tizesSzam - this.Szamok[i] >= 0)
                {
                    this.tizesSzam = this.tizesSzam - this.Szamok[i];
                    this.binaris += "1 ";
                }
                else
                {
                    this.binaris += "0 ";
                }
            }
        }

        public string getBinaris()
        {
            return String.Format("Kettes számrendszeri értéke: {0}",this.binaris);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adja meg a tízes számrendszerbeli számot.");
            KettesSzamrendszer binary = new KettesSzamrendszer(Int32.Parse(Console.ReadLine()));
            binary.Szamolas();
            Console.WriteLine(binary.getBinaris());
            Console.ReadKey();
        }
    }
}
