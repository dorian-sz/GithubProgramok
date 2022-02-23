using System;

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
			return "Férfi";
        }
        else
        {
			return "Nő";
        }
    }
	public int Szerencseszam()
    {
		Random rnd = new Random();
		szama = rnd.Next();
		return szama
	}


}
