using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Henger
{
    class Henger
    {
        public double magassag;
        public double sugar;

        public void setSugar()
        {
            this.sugar = Convert.ToDouble(Console.ReadLine());
        }

        public void setMagas()
        {
            this.magassag = Convert.ToDouble(Console.ReadLine());
        }
        public double getKerulet()
        {
            return 2 * Math.PI * this.sugar; 
        }

        public double getTerulet()
        {
            return Math.PI * Math.Pow(this.sugar, 2);
        }

        public double getFelszin()
        {
            return 2 * Math.PI * Math.Pow(this.sugar, 2) + 2 * Math.PI * this.sugar * this.magassag;
        }

        public double getTerfogat()
        {
            return this.magassag * Math.PI * Math.Pow(this.sugar, 2);
        }
    }
}
