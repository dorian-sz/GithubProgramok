using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binaris
{
    class BinarisSzam
    {
        private string binaris;

        public BinarisSzam(string binaris)
        {
            this.binaris = binaris;
        }

        public int BinarisCount()
        {
            return binaris.Count(f => f == '1');
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            BinarisSzam binary = new BinarisSzam(Console.ReadLine());

            Console.WriteLine(binary.BinarisCount());

            Console.ReadKey();
        }
    }
}
