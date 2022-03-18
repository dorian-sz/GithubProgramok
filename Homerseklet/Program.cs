using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homerseklet
{
    class Program
    {
        static void Main(string[] args)
        {
             Dictionary<int, string> months =   {1, "Január"}, {2, "Február"}, {3, "Március"}, {4, "Április"},
                                                {5, "Május"}, {6, "Június"}, {7, "Július"}, {8, "Augusztus"},
                                                {9, "Szeptember"}, {10, "Október"}, {11, "November"}, {12, "December"}; 
            Months winter = new Months(-15, 10);

            winter.fillList();
            
            Console.WriteLine(months["Január"]);

            Console.ReadKey();

        }
    }
}
