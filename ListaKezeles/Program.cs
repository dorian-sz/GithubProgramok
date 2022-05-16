using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaKezeles
{
    class Program
    {
        static void Main(string[] args)
        {
            Varosok v = new Varosok();

            v.setDb();
            v.setNevek();
            v.getNevek();
            v.getVan();
            v.delNev();
            v.getNevek();
            v.delLast();
            v.getNevek();

            Console.ReadKey();
        }
    }
}