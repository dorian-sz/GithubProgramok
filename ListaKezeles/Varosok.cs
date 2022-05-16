using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaKezeles
{
    class Varosok
    {
        private int db;
        private string nev;
        private List<string> varosok;

        public Varosok()
        {
            this.varosok = new List<string>();
        }
        public void setDb()
        {
            Console.WriteLine("Adja meg hány várost akar megadni.");
            try
            {
                this.db = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {

                this.db = -1;
            }
        }

        public void setNevek()
        {
            if (this.db !=0)
            {
                Console.WriteLine("Adja meg a város nevét.");
                this.nev = Console.ReadLine();
                if (this.db == -1)
                {
                    if (!String.IsNullOrEmpty(this.nev))
                    {
                        this.varosok.Add(this.nev);
                        this.setNevek();
                    }
                }
                if (this.db > 0)
                {
                    this.varosok.Add(this.nev);
                    this.db--;
                    this.setNevek();
                }
            }

        }
        public void getNevek()
        {
            Console.WriteLine(string.Join(",", this.varosok));
        }
        public void getVan()
        {
            Console.WriteLine("Adja meg a nevet");
            this.nev = Console.ReadLine();
            bool szerepel = false;
            
            foreach (var item in this.varosok)
            {
                if (item.ToLower() == this.nev.ToLower())
                {
                    szerepel = true;
                    Console.WriteLine("Ez a név szerepel a listában.");     

                }
            }
            if (szerepel == false)
            {
                Console.WriteLine("Ez a név nem szerepel a listában.");
            }
        }
        public void delNev()
        {
            
            Console.WriteLine("Adja meg a nevet");
            this.nev = Console.ReadLine();
            bool szerepel = false;

            foreach (var item in this.varosok)
            {
                if (item.ToLower() == this.nev.ToLower())
                {
                    szerepel = true;
                }
            }
            if (szerepel == true)
            {
                this.varosok.Remove(this.nev);
            }
            if (szerepel == false)
            {
                this.varosok.Add(this.nev);
            }
        }

        public void delLast()
        {
            this.varosok.RemoveAt(this.varosok.Count()-1);
        }

    }
}
