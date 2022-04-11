using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elagazas
{
    class Elagazas
    {
        private List<int> Szamok;
        Random rnd;

        public Elagazas()
        {
            Szamok = new List<int>();
            rnd = new Random();
        }

        public void Feltolt()
        {
            for (int i = 0; i < 15; i++)
            {
                this.Szamok.Add(this.rnd.Next(10, 100));
            }
        }

        public void Kiir()
        {
            foreach (var item in this.Szamok)
            {
                if (item % 2 == 0)
                {
                    Console.WriteLine("Szám: {0}", item);
                }
            }

        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Elagazas elagazas = new Elagazas();

            elagazas.Feltolt();
            elagazas.Kiir();

            Console.ReadKey();
        }
    }
}
