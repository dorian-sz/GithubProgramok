using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listak
{
    class Listak
    {
        List<int> Szamok;
        Random rnd;

        public Listak()
        {
            Szamok = new List<int>();
            rnd = new Random();
        }

        public void Feltolt()
        {
            for (int i = 0; i < 15; i++)
            {
                this.Szamok.Add(rnd.Next(10, 100));
            }
        }

        public void Kiir()
        {
            foreach (var item in this.Szamok)
            {
                Console.WriteLine("Szám: {0}", item);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Listak elagazas = new Listak();

            elagazas.Feltolt();
            elagazas.Kiir();

            Console.ReadKey();
        }
    }
}
