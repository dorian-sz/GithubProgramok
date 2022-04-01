using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szamrendszer
{
    class SzamrendszerValto
    {
        private double TizesSzam; 
        private string Eredmeny;
        private int[] Szamok;

        public SzamrendszerValto(double tizesSzam)
        {
            this.Eredmeny = "";
            this.TizesSzam = tizesSzam;
            this.Szamok = new int[] { 128, 64, 32, 16, 8, 4, 2, 1 };
        }

        public void BinarisSzamolas()
        {
            for (int i = 0; i < this.Szamok.Length; i++)
            {
                if (this.TizesSzam - this.Szamok[i] >= 0)
                {
                    this.TizesSzam = this.TizesSzam - this.Szamok[i];
                    this.Eredmeny += "1 ";
                }
                else
                {
                    this.Eredmeny += "0 ";
                }
            }
        }
        public string getEredmeny()
        {
            return String.Format("Kettes számrendszeri értéke: {0}", this.Eredmeny);
        }

        public void Octal()
        {
            while (TizesSzam > 0)
            {
                Console.WriteLine("Eredmeny: {0}, TizesSzam: {1}", this.Eredmeny, this.TizesSzam);

                this.Eredmeny += Convert.ToString(this.TizesSzam % 8);
                this.TizesSzam = Math.Floor(this.TizesSzam / 8.0);

            }
           
        }
    }
}
