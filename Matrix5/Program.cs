using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix5
{
    class Matrix
    {
        private string[,] matrix;
        private int xIndex, yIndex, prevX, prevY;
        private string val, choice;


        public Matrix(int sizex, int sizey)
        {
            this.matrix = new string[sizey, sizex];
            this.prevX = -2;
            this.prevY = -2;
        }

        public void AddElement()
        {
            if (this.yIndex < this.matrix.GetLength(0))
            {
                if (this.xIndex < this.matrix.GetLength(1))
                {
                    if (this.xIndex == this.prevX && this.yIndex == this.prevY)
                    {
                        Console.WriteLine("Ezen az indexen már van érték. Adjon meg új indexet és értéket.");
                    }
                    else
                    {
                        this.matrix[this.xIndex, this.yIndex] = this.val;
                    }
                }
            }
            else
            {
                Console.WriteLine("Tömb értékein kívül hivatkozott.");
            }
        }

        public void FillEmpty()
        {
            for (int i = 0; i < this.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < this.matrix.GetLength(1); j++)
                {
                    if (this.matrix[i,j] == null)
                    {
                        this.matrix[i, j] = "-1";
                    }
                }
            }
        }
        public string[,] GetMatrix()
        {
            return this.matrix;
        }
        public void SetIndexAndValue(string indexval)
        {
            this.xIndex = Int32.Parse(Convert.ToString(indexval.Split(',')[0]));
            this.yIndex = Int32.Parse(Convert.ToString(indexval.Split(',')[1]));
            this.val = Convert.ToString(indexval.Split(',')[2]);

        }
        public void SetPrevIndexes()
        {
            this.prevX = this.xIndex;
            this.prevY = this.yIndex;
        }
        public bool Continue()
        {
            if (this.choice == "igen")
            {
                return true;
            }
            if (this.choice == "nem")
            {
                this.FillEmpty();
                return false;
            }
            for (int i = 0; i < this.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < this.matrix.GetLength(1); j++)
                {
                    if (this.matrix[i, j] == null)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public void MatrixOut()
        {
            Console.Write(Environment.NewLine);
            for (int i = 0; i < this.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < this.matrix.GetLength(1); j++)
                {
                    Console.Write("{0} ", this.matrix[i, j]);
                }
                Console.Write(Environment.NewLine);
            }
        }

        public void SetChoice(string c)
        {
            this.choice = c;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            string IndVal;
            Console.WriteLine("Adja meg az Sorok és Oszlopok méretét: ");
            Matrix m = new Matrix(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            Console.Write(Environment.NewLine);
            while (m.Continue())
            {
                Console.WriteLine("Ajda meg az x indexet, y indexet és a számot: ");
                IndVal = Console.ReadLine();
                m.SetIndexAndValue(IndVal);
                m.AddElement();
                m.SetPrevIndexes();
                Console.WriteLine("Akarja folytatni? ");
                m.SetChoice(Console.ReadLine());
            }

            m.MatrixOut();

            Console.ReadKey();
        }
    }
}
