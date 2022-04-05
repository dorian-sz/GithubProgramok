using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BastyaSakkTabla
{
    class Board
    {
        private int[] board;

        public Board()
        {
            this.board = new int[64];
        }

        public void PlaceRook()
        {
            for (int i = 0; i < this.board.Length; i++)
            {
                if (this.board[i] != 1)
                {
                    this.board[i] = 1;
                    for (int j = 0; j < this.board.Length; j+=8)
                    {
                        this.board[j] = 1;
                    }
                }
            }
        }

        public int[] GetBoard()
        {
            return this.board;
        }

    }
}
