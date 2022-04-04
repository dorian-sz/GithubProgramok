using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Fibonacci
    {
        private int[] szamok;
        public Fibonacci(int length)
        {
            this.szamok = new int[length];
        }

        public void FillList()
        {
            this.szamok[0] = 0;
            this.szamok[1] = 1;
            for (int i = 1; i < this.szamok.Length-1; i++)
            {   
                this.szamok[i+1] = this.szamok[i] + this.szamok[i-1];
            }
        }
        public int[] GetArray()
        {
            return this.szamok;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adja meg a sorozat hosszát: ");
            Fibonacci fibonacci = new Fibonacci(Convert.ToInt32(Console.ReadLine()));

            fibonacci.FillList();
            foreach (var item in fibonacci.GetArray())
            {
                Console.WriteLine("Szám: {0}", item);
            }

            Console.ReadKey();
        }
    }
}
