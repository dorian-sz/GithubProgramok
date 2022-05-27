using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxmain
{
    public class MinMaxclass
    {
        public int[] arr;
        public int usrNum;
        
        public MinMaxclass(int size)
        {
            this.arr = new int[size];
        }

        public void randomFeltolt()
        {
            Random random = new Random();
            
            for (int i = 0; i < this.arr.Length; i++)
            {
                this.arr[i] = random.Next();
            }
        }

        public void userFeltolt()
        {
            for (int i = 0; i < this.arr.Length; i++)
            {
                this.usrNum = Convert.ToInt32(Console.ReadLine());
                this.arr[i] = this.usrNum;
            }
        }

        public void arrSort()
        {
            Array.Sort(this.arr);
        }

        public int getMin()
        {
            return this.arr[0];
        }

        public int getMax()
        {
            return this.arr[this.arr.Length - 1];
        }
    }
}
