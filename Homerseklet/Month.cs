using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homerseklet
{
    class Months
    {
        private string monthName;
        private int[,,] temperature;
        private int[] aList;
        private int averageTemp, minTemp, maxTemp;
        
        public Months(string monthName, int minTemp, int maxTemp)
        {
            this.minTemp = minTemp;
            this.maxTemp = maxTemp;
            this.monthName = monthName;
            this.temperature = new int[3,30, 2];
        }

        public void fillList()
        {
            Random rnd = new Random();
            for (int i = 0; i < this.temperature.GetLength(0); i++)
            {
                for (int j = 0; j < this.temperature.GetLength(1); j++)
                {
                    for (int k = 0; k < this.temperature.GetLength(2); k++)
                    {
                        this.temperature[i, j, k] = rnd.Next(this.minTemp, this.maxTemp);
                    }
                }
            }
        }

        public int[] getMonthTemperature()
        {
            
        }

        public int getMaxTemp()
        {
            return this.temperature.Cast<int>().Max();
        }

        public int getMinTemp()
        {
            return this.temperature.Cast<int>().Min();
        }

    }
}
