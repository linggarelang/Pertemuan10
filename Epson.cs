using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace printerApps
{
    public class Epson : IPrinter
    {
        public void showPrint(Printer printer)
        {
            Console.WriteLine("\nEpson display dimensions : 10*11");
            Console.WriteLine("Epson Printer Printing...");
        }
    }
}