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
        private string Eredmeny2;
        private int HexEredmeny;
        private Dictionary<int,string> HexDic;
        private int[] Szamok;

        public SzamrendszerValto(double tizesSzam)
        {
            
            this.TizesSzam = tizesSzam;
            this.Szamok = new int[] { 128, 64, 32, 16, 8, 4, 2, 1 };
            this.HexDic = new Dictionary<int, string> { { 0, "8"},{ 1, "4"},{ 2, "2"},{ 3, "1"}, { 10, "A"},{ 11, "B"},{ 12, "C"},{ 13, "D"},{ 14, "E"},{ 15, "F"} };
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
            this.Eredmeny2 = "";
            this.TizesSzamEredmeny = this.TizesSzam;
            for (int i = 0; i < this.Szamok.Length; i++)
            {
                if (this.TizesSzamEredmeny - this.Szamok[i] >= 0)
                {
                    this.TizesSzamEredmeny = this.TizesSzamEredmeny - this.Szamok[i];

                    if (this.Eredmeny.Length < 4)
	                {
                        this.Eredmeny += "1";
	                }
                    else
	                {
                        this.Eredmeny2 += "1";
	                }
                    
                }
                else
                {
                    if (this.Eredmeny.Length < 4)
	                {
                        this.Eredmeny += "0";
	                }
                    else
	                {
                        this.Eredmeny2 += "0";
	                }
                }
            }
            for (int i = 0; i < this.Eredmeny.Length; i++)
			{
                if (this.Eredmeny[i] == '1')
	            {
                    this.HexEredmeny += Convert.ToInt32(this.HexDic[i]);
	            }

			}

            if (this.HexEredmeny >= 10)
	        {
                this.Eredmeny = this.HexDic[this.HexEredmeny];
	        }
            else
	        {
                this.Eredmeny = Convert.ToString(this.HexEredmeny);
	        }

            this.HexEredmeny = 0;
            for (int i = 0; i < this.Eredmeny2.Length; i++)
			{
                if (this.Eredmeny2[i] == '1')
	            {
                    this.HexEredmeny += Convert.ToInt32(this.HexDic[i]);
	            }

			}

            if (this.HexEredmeny >= 10)
	        {
                this.Eredmeny += this.HexDic[this.HexEredmeny];
	        }
            else
	        {
                this.Eredmeny += Convert.ToString(this.HexEredmeny);
	        }

            return this.Eredmeny;
        }

    }
}
