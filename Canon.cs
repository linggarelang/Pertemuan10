using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace printerApps
{
    public class Canon : IPrinter
    {
        public void showPrint(Printer printer)
        {
            Console.WriteLine("\nCanon display dimensions : 9.5*12");
            Console.WriteLine("Canon Printer Printing...");
        }
    }
}