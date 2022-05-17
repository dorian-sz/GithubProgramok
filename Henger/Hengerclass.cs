using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Henger
{
    public class ConsoleInRetriever
    {
        public virtual double setSugar()
        {
            return Convert.ToDouble(Console.ReadLine());
        }
        public virtual double setMagas()
        {
            return Convert.ToDouble(Console.ReadLine());
        }
    }
    public class Hengerclass : ConsoleInRetriever
    {
        public double magassag;
        public double sugar;
        public Hengerclass()
        {

        }

        public override double setSugar()
        {
            return this.sugar = Convert.ToDouble(Console.ReadLine());
        }
        public override double setMagas()
        {
            return this.magassag = Convert.ToDouble(Console.ReadLine());
        }
        public double getKerulet()
        {
            return Math.Round(2 * Math.PI * this.sugar,2); 
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
