using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kor
{
    class Kor
    {
        private double sugara;

        public Kor()
        {
        }

        public double getTerulet()
        {
            return this.sugara * this.sugara * 3.14;
        }

        public double getKerulet()
        {
            return 2 * 3.14 * this.sugara;
        }

        public void setSugara()
        {
            this.sugara = Convert.ToDouble(Console.ReadLine());
        }

    }

    class Henger : Kor
    {
        private double magassag;

        public Henger() : base()
        {

        }

        public double getTerfogat()
        {
            return this.getAlapterulet() * this.magassag;
        }
        public double getAlapterulet()
        {
            return this.getTerulet();
        }

        public void setMagassag()
        {
            this.magassag = Convert.ToDouble(Console.ReadLine());
        }
    }

    //henger magasság, method térfogat, alapterület.
    class Program
    {
        static void Main(string[] args)
        {
            Henger h = new Henger();

            Console.WriteLine("Adja meg a kor sugarat");
            h.setSugara();

            Console.WriteLine("Kor terulete: {0} es kerulete: {1}", h.getTerulet(), h.getKerulet());

            Console.WriteLine("Adja meg a magassagat");
            h.setMagassag();

            Console.WriteLine("Henger terfogata: {0} es alapterulete: {1}", h.getTerfogat(), h.getAlapterulet());

            Console.ReadKey();
        }
    }
}
