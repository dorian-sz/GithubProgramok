using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixBill3
{
    class Matrix : Index
    {
        private int[,] matrix;
        private int xIndex, yIndex, pxIndex, pyIndex;

        public Matrix(int sizex, int sizey)
        {
            this.matrix = new int[sizey, sizex];
            this.xIndex = 0;
            this.yIndex = 0;
        }

        public void AddElement(int n)
        {
            if (this.yIndex < this.matrix.GetLength(0))
            {
                if (this.xIndex < this.matrix.GetLength(1))
                {
                    this.matrix[this.yIndex, this.xIndex] = n;
                    this.pyIndex = this.yIndex;
                    this.pxIndex = this.xIndex;
                    if (this.pxIndex == this.xIndex && this.pyIndex = this.yIndex)
	                {
                        this.IndexOut(this.xIndex, this.yIndex);
	                }
                    
                    this.xIndex++;
                }
                else
                {
                    this.yIndex++;
                    this.xIndex = 0;
                    this.matrix[this.yIndex, this.xIndex] = n;
                    this.IndexOut(this.xIndex, this.yIndex);
                    this.xIndex++;
                }
            }
            else
            {
                Console.WriteLine("Mátrix tele van.");
            }

        }

        public int YIndex()

        public int[,] GetMatrix()
        {
            return this.matrix;
        }


    }

    class Index
    {

        public void IndexOut(int x, int y)
        {
            Console.WriteLine("Ez az index: {0}, {1} már foglalt.",y, x);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Adja meg az Sorok és Oszlopok méretét: ");
            Matrix m = new Matrix(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            Console.Write(Environment.NewLine);
            for (int i = 0; i < m.GetMatrix().GetLength(0); i++)
            {
                for (int j = 0; j < m.GetMatrix().GetLength(1); j++)
                {
                    Console.WriteLine("Ajda meg a számot:");
                    n = Convert.ToInt32(Console.ReadLine());
                    m.AddElement(n);

                }
            }

            Console.Write(Environment.NewLine);
            for (int i = 0; i < m.GetMatrix().GetLength(0); i++)
            {
                for (int j = 0; j < m.GetMatrix().GetLength(1); j++)
                {
                    Console.Write("{0} ", m.GetMatrix()[i, j]);
                }
                Console.Write(Environment.NewLine);
            }

            Console.ReadKey();
        }
    }
}

