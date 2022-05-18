using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AutokLista
{
    class Autoclass
    {
        public List<string> autoAdatok;
        public string fileName;

        public Autoclass(string filename)
        {
            this.fileName = filename;
        }

        public void readFile()
        {
            this.autoAdatok = new List<string>(File.ReadAllLines(fileName));
        }

        public void outFile()
        {
            Console.WriteLine("{0} {1,14} {2,8} {3,19} {4,30} {5,20}\n", "Rendszám", "Gyártmány", "Típus", "Gyártási év", "Műszaki vizsga érvényessége", "Tulajdonos neve");
            foreach (string lines in this.autoAdatok)
            {
                Console.Write("{0} {1,10} {2,16} {3,9} {4,14} {5,43}\n", lines.Split(',')[0], lines.Split(',')[1], lines.Split(',')[2], lines.Split(',')[3], lines.Split(',')[4], lines.Split(',')[5]);
            

            }
        }
    }

}
