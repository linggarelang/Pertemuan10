using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace printerApps
{
    public class LaserJet : IPrinter
    {
        public void showPrint(Printer printer)
        {
            Console.WriteLine("\nLaserJet display dimensions : 12*12");
            Console.WriteLine("LaserJet Printer Printing...");
        }
    }
}