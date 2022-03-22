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
        private string monthName;
        private int[,] temperature;
        private int[] aList;
        private int averageTemp, minTemp1, maxTemp1 , minTemp2, maxTemp2;
        
        public Months(int minTemp1, int minTemp2, int maxTemp1, int maxTemp2, int m)
        {
            this.m = m;
            this.minTemp1 = minTemp1;
            this.maxTemp1 = maxTemp1;
            this.minTemp2 = minTemp2;
            this.maxTemp2 = maxTemp2;
            this.temperature = new int[30,4];
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
                    Console.WriteLine("Hónap: {0}, Nap: {1}, Min hőmérséklet: {2}, Max hőmérséklet: {3}, Átlag hőmérséklet: {4}", this.temperature[i,0], this.temperature[i,1], this.temperature[i,2],this.temperature[i,3], (this.temperature[i,2] + this.temperature[i,3]) / 2);
	            }
			}
            
        }

        public void getMinMaxAvgTempMonth(int month)
        {
            int min=Enumerable.Range(0, this.temperature.GetLength(0)).Select(x => this.temperature[x, 2]).Min();
            int max=Enumerable.Range(0, this.temperature.GetLength(0)).Select(x => this.temperature[x, 3]).Max();
            int avg=(min+max)/2;

            Console.WriteLine("Ebben a hónapban: Min hőmérséklet: {0}, Max hőmérséklet: {1}, Átlag hőmérséklet: {2}", min,max,avg);
            
        }
    }
}
