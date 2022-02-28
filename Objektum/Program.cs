using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objektum
{
	public class Smoothies
	{
		static Dictionary<string, string> prices = new Dictionary<string, string>()
		{
			{ "Strawberries", "$1.50" },
			{ "Banana", "$0.50" },
			{ "Mango", "$2.50" },
			{ "Blueberries", "$1.00" },
			{ "Raspberries", "$1.00" },
			{ "Apple", "$1.75" },
			{ "Pineapple", "$3.50" }
		};

		public string[] Ingeridents;
		double total;

        public Smoothies(string[] ingerdient)
        {
			this.Ingeridents = ingerdient;
			this.total = 0;
        }

		public double GetCost()
        {
			foreach (var item in Ingeridents)
			{
				total = total + prices[item];
			}
			return total;

        }

	}
	class Program
    {
        static void Main(string[] args)
        {
			Smoothies s1 = new Smoothies(new string[] { "Banana" });
			Console.WriteLine(s1.GetCost());


			Console.ReadKey();
        }
    }
}
