using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace szuletett
{
	public class Szuletett
	{
		String nev;
		String foglalkozas;
		String neme;
		int szama;

		public Szuletett(String nev, String foglalkozas, String neme)
		{
			this.nev = nev;
			this.foglalkozas = foglalkozas;
			this.neme = neme;
			this.szama = 0;
		}
		public string Nem()
		{
			if (neme == "f")
			{
				return "férfi";
			}
			else
			{
				return "nő";
			}
		}
		public int Szerencseszam()
		{
			Random rnd = new Random();
			szama = rnd.Next(50);
			return szama;
		}
		public string Output()
        {
			return String.Format("{0} egy {1} {2} volt, szerencse száma a {3}", nev, foglalkozas, Nem(), Szerencseszam());
		}
	}


	class Program
    {
        static void Main(string[] args)
        {
			
            for (int i = 0; i < 3; i++)
            {
				Console.WriteLine("Adja meg a nevét");
				string neve = Console.ReadLine();

				Console.WriteLine("Adja meg a foglalkozást");
				string foglalkozas = Console.ReadLine();

				Console.WriteLine("Adja meg a nemét");
				string neme = Console.ReadLine();

				Szuletett szemely = new Szuletett(neve, foglalkozas, neme);
				Console.WriteLine(szemely.Output());

			}

			Console.ReadKey();
            
        }
    }
}
