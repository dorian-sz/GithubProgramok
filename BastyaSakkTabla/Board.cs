using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BastyaSakkTabla
{
    class Board
    {
        private int[,] board;

        public Board()
        {
            this.board = new int[8,8];
        }

        public void PlaceRook()
        {
            this.board[2,0] = 1;
            for (int i = 0; i < this.board.GetLength(0); i++)
			{
                for (int j = 0; j < this.board.GetLength(1); j++)
			    {
                    if (this.board[i,j] == 1)
	                {
                        Console.WriteLine("{0}, {1}", i,j);
                        this.board[i, j] = 
	                }
			    }
			}

        }

        public void BoardOut()
        {
            for (int i = 0; i < this.board.GetLength(0); i++)
            {
                for (int j = 0; j < this.board.GetLength(1); j++)
                {
                    Console.Write("{0} ", this.board[i, j]);
                }
                Console.Write(Environment.NewLine);
            }
        }
    }
}
