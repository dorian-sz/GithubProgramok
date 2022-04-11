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
                    Console.WriteLine("index1 {0}, index2 {1}, val {2}",i,j,this.board[i,j]);
			    }
            }
        }
    }
}
