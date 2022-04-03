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
        private double TizesSzamEredmeny;
        private string Eredmeny;
        private Dictionary<int,string> Hexa;
        private int[] Szamok;

        public SzamrendszerValto(double tizesSzam)
        {
            
            this.TizesSzam = tizesSzam;
            this.Szamok = new int[] { 128, 64, 32, 16, 8, 4, 2, 1 };
        }

        public string BinarisSzamolas()
        {
            this.Eredmeny = "";
            this.TizesSzamEredmeny = this.TizesSzam;
            for (int i = 0; i < this.Szamok.Length; i++)
            {
                if (this.TizesSzamEredmeny - this.Szamok[i] >= 0)
                {
                    this.TizesSzamEredmeny = this.TizesSzamEredmeny - this.Szamok[i];
                    this.Eredmeny += "1 ";
                }
                else
                {
                    this.Eredmeny += "0 ";
                }
            }
            return this.Eredmeny;
        }

        public string Octal()
        {
            this.Eredmeny = "";
            this.TizesSzamEredmeny = this.TizesSzam;
            if (this.TizesSzam == 0)
	        {
               this.Eredmeny = "0";
	        }
            while (this.TizesSzamEredmeny > 0)
            {
                this.Eredmeny = Convert.ToString(this.TizesSzamEredmeny % 8) + this.Eredmeny;
                this.TizesSzamEredmeny = Math.Floor(this.TizesSzamEredmeny / 8.0);

            }
            return this.Eredmeny;
        }

        public string Hex()
        {
            this.Eredmeny = "";

            for (int i = 0; i < this.Szamok.Length; i++)
            {
                if (this.TizesSzamEredmeny - this.Szamok[i] >= 0)
                {
                    this.TizesSzamEredmeny = this.TizesSzamEredmeny - this.Szamok[i];
                    this.Eredmeny += "1 ";
                }
                else
                {
                    this.Eredmeny += "0 ";
                }
            }
        }

    }
}
