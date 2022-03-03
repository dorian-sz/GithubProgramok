using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Allat
    {
        string nev;
        string fajta;
        string szin;
        int kor;
        string hang;

        public Allat(string nev, string fajta, string szin)
        {

            this.nev = nev;
            this.fajta = fajta;
            this.szin = szin;

        }
        public Allat()
        {
            this.nev = "Állat";
            this.fajta = "Valami";
            this.szin = "Fekete";
            this.kor = 0;
        }

        public string GetNev()
        {
            return this.nev;
        }
        public string GetFajta()
        {
            return this.fajta;
        }
        public string GetSzin()
        {
            return this.szin;
        }
        public int GetKor()
        {
            return this.kor;
        }

        public void SetKor(int p)
        {
            if (p > 0 && p < 50)
            {
                this.kor = p;
            }
        }

    }
    class Program
    {

        static void Main(string[] args)
        {
        }
    }
}
