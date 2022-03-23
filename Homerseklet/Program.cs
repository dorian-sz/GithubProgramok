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


            Months[] months_objects = { new Months(-12, -5, -4, 5, 1, "Tél"),
                                        new Months(-10, -6, -5, 2, 2, "Tél"),
                                        new Months(-5, 3, 4, 15, 3, "Tavasz"),
                                        new Months(4, 9, 10, 24, 4, "Tavasz"),
                                        new Months(6, 9, 10, 26, 5, "Tavasz"),
                                        new Months(10, 14, 15, 29, 6, "Nyár"),
                                        new Months(12, 15, 16, 30, 7, "Nyár"),
                                        new Months(12, 15, 16, 37, 8, "Nyár"),
                                        new Months(8, 14, 15, 27, 9, "Ősz"),
                                        new Months(5, 13, 14, 22, 10, "Ősz"),
                                        new Months(1, 10, 11, 18, 11, "Ősz"),
                                        new Months(-4, 6, 7, 12, 12, "Tél")    };

            
            foreach (var item in months_objects)
	        {
                item.fillList();
                
	        }
            int honap = months[Console.ReadLine()];
            int nap = Int32.Parse(Console.ReadLine());
            months_objects[honap-1].getMinMaxAvgTempDay(nap);

            months_objects[honap-1].getMinMaxAvgTempMonth(honap);
            


            
            Console.ReadKey();

        }
    }
}