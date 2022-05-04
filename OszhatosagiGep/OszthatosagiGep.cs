using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OszhatosagiGep
{
    class OszthatosagiGep
    {
        public double szam;

        public void setSzam()
        {

            try
            {
                this.szam = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Számjegyet adjon meg.");
                this.setSzam();
            }
        }
        
        public double getSzam()
        {
            if (this.szam % 3 == 0)
            {
                return 3;
            }
            if (this.szam % 5 == 0)
            {
                return 5;
            }
            else
            {
                return szam;
            }
        }
    }
}
