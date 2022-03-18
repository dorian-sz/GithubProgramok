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
             Dictionary<string,int> months =   new Dictionary<string,int>{{"Január",1}, {"Február",2}, {"Március",3}, {"Április",4},
                                                {"Május",5}, {"Június",6}, {"Július",7}, {"Augusztus",8},
                                                {"Szeptember",9}, {"Október",10}, {"November",11}, {"December",12}}; 
            Months winter = new Months(-15, 10, 12);

            winter.fillList();
            int honap = months[Console.ReadLine()];
            winter.getMinMaxAvgTemp(honap);
            Console.ReadKey();

        }
    }
}
