﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szamrendszer
{
    class Menu
    {
        public void MenuKi()
        {
            Console.WriteLine("Menüpontok:\n1.Első menü.\n2.Második menü.\n3.Harmadik menü.\n4.Negyedik menü.\n5.Kilépés.");
        }

        public void MenuPontok(int opcio)
        {
            switch (opcio)
            {
                case 1:
                    Console.WriteLine("Ez az első menüpont.");
                    break;
                case 2:
                    Console.WriteLine("Ez a második menüpont.");
                    break;
                case 3:
                    Console.WriteLine("Ez a harmadik menüpont.");
                    break;
                case 4:
                    Console.WriteLine("Ez a negyedik menüpont.");
                    break;
                case 5:
                    break;
            }
        }
    }
}
