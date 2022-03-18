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
        private int averageTemp, minTemp, maxTemp;
        
        public Months(int minTemp, int maxTemp, int m)
        {
            this.m = m;
            this.minTemp = minTemp;
            this.maxTemp = maxTemp;
            this.temperature = new int[90,4];
        }

        public void fillList()
        {
            Random rnd = new Random();
            int d = 1;
            for (int i = 0; i < this.temperature.GetLength(0); i++)
            {
                if (d > 30)
	            {
                    this.m++;
                    if (this.m > 12)
	                {
                        this.m = 1;
	                }
                    d = 1;
	            }
                this.temperature[i, 0] = this.m;
                this.temperature[i, 1] = d;
                this.temperature[i, 2] = rnd.Next(this.minTemp, this.maxTemp);
                this.temperature[i, 3] = rnd.Next(this.minTemp, this.maxTemp);
                d++;
            }
        }


        public void getMinMaxAvgTemp(int month)
        { 
            int max = -50;
            for (int i = 0; i < this.temperature.GetLength(0); i++)
			{
                if (this.temperature[i,0] == month)
	            {
	            }
			}
            Console.WriteLine("Hónap: {2}, Első: {0}, Második: {1}",this.temperature[i,2],this.temperature[i,3], this.temperature[i,0]);
        }
    }
}
