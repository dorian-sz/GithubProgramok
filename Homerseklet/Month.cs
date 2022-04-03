using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homerseklet
{
    class Months
    {
        private int m;
        private int[,] temperature;
        private List<int> temps;
        private string evszak;
        private int minTemp1, maxTemp1 , minTemp2, maxTemp2;
        private double averageTemp;
        
        public Months(int minTemp1, int minTemp2, int maxTemp1, int maxTemp2, int m, string evszak)
        {
            this.m = m;
            this.evszak = evszak;
            this.minTemp1 = minTemp1;
            this.maxTemp1 = maxTemp1;
            this.minTemp2 = minTemp2;
            this.maxTemp2 = maxTemp2;
            this.temperature = new int[30,4];
            this.temps = new List<int>();
        }

        public void fillList()
        {
            Random rnd = new Random();
            int d = 1;
            for (int i = 0; i < this.temperature.GetLength(0); i++)
            {
                if (d > 30)
	            {
                    d = 1;
	            }
                this.temperature[i, 0] = this.m;
                this.temperature[i, 1] = d;
                this.temperature[i, 2] = rnd.Next(this.minTemp1, this.minTemp2);
                this.temperature[i, 3] = rnd.Next(this.maxTemp1, this.maxTemp2);
                d++;
            }
        }


        public void getMinMaxAvgTempDay(int day)
        { 
            for (int i = 0; i < this.temperature.GetLength(0); i++)
			{
                
                if (this.temperature[i,1] == day)
	            {
                    this.averageTemp = (Convert.ToDouble(this.temperature[i,2]) + Convert.ToDouble(this.temperature[i,3])) / 2;
                    Console.WriteLine("Ebben a hónapban: {0}, Ezen a napon: {1}, Min hőmérséklet: {2}, Max hőmérséklet: {3}, Átlag hőmérséklet: {4}", this.temperature[i,0], this.temperature[i,1], this.temperature[i,2],this.temperature[i,3], this.averageTemp);
	            }
			}
            
        }

        public void getMinMaxAvgTempMonth(int month)
        {
            double sum = 0;
            int min=Enumerable.Range(0, this.temperature.GetLength(0)).Select(x => this.temperature[x, 2]).Min();
            int max=Enumerable.Range(0, this.temperature.GetLength(0)).Select(x => this.temperature[x, 3]).Max();
            for (int i = 0; i < this.temperature.GetLength(0); i++)
			{
                sum = sum + Convert.ToDouble(this.temperature[i,2]);
                sum = sum + Convert.ToDouble(this.temperature[i,3]);
			}
            sum = sum / (this.temperature.GetLength(0)*2);
            Console.WriteLine("Ebben a hónapban: {0}, Min hőmérséklet: {1}, Max hőmérséklet: {2}, Átlag hőmérséklet: {3}", month, min,max,Math.Round(sum, 1));
            
        }

        public string getEvszak()
        {
            return this.evszak;
        }

        public List<int> getTemps()
        {
            for (int i = 0; i < this.temperature.GetLength(0); i++)
			{
                this.temps.Add(this.temperature[i,2]);
                this.temps.Add(this.temperature[i,3]);
                
			}

            return this.temps;
        }
    }
}
