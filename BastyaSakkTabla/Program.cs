using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BastyaSakkTabla
{
    class Program
    {
        static void Main(string[] args)
        {

            Board chessboard = new Board();
            chessboard.PlaceRook();

            Console.ReadKey();
        }
    }
}
