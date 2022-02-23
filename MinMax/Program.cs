using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMax
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] arr = { 1, 5, 2, 12, 4, 3, 5, -5 };
            Array.Sort(arr);
            Console.WriteLine("Legkisebb: {0}", arr[0]);
            Console.WriteLine("Legnagyobb: {0}", arr[arr.Length - 1]);

            Console.ReadLine();
        }
        
    }
}
