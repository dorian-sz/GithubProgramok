using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegySzog
{
    public class Negyszog
    {
        //Tagváltozó
        public double Side { get; set; }
        
        //Konstruktor
        public Negyszog(double side)
        {
            this.Side = side;
        }

        public double Kerulet()
        {
            return 4.0 * this.Side;
        }

        public double Terulet()
        {
            return Math.Pow(this.Side, 2);
        }

        public double Atlo()
        {
            return Math.Sqrt(2 * Math.Pow(this.Side, 2));
        }
    }
}
