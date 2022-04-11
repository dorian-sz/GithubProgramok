using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAndForeach
{
    class ForAndForeach
    {
        private List<int> Szamok;
        private Random rnd;

        public ForAndForeach()
        {
            this.Szamok = new List<int>();
            this.rnd = new Random();
        }

        public void Feltolt()
        {
            for (int i = 0; i < 15; i++)
            {
                this.Szamok.Add(this.rnd.Next(10, 100));
            }
        }

        public void ForKiir()
        {
            for (int i = 0; i < this.Szamok.Count; i++)
            {
                Console.WriteLine("For kiiras: {0}", this.Szamok[i]);
            }
        }

        public void ForeachKiir()
        {
            foreach (var item in this.Szamok)
            {
                Console.WriteLine("Foreach kiiras: {0}", item);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ForAndForeach feladat = new ForAndForeach();

            feladat.Feltolt();
            feladat.ForKiir();
            feladat.ForeachKiir();

            Console.ReadKey();
        }
    }
}
