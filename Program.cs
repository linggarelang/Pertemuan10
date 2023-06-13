using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace printerApps
{
    public class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();

            Console.WriteLine("Pilih Printer : ");
            Console.WriteLine("1. Printer Epson ");
            Console.WriteLine("2. Printer Canon ");
            Console.WriteLine("3. Printer LaserJet ");
            Console.Write("Pilih Nomor Printer [1...3] : ");
            int numOfPrinter = Convert.ToInt32(Console.ReadLine());

            // Declare
            IPrinter print;

            switch (numOfPrinter)
            {
                case 1:
                    print = new Epson(); print.showPrint(printer); break;
                case 2:
                    print = new Canon(); print.showPrint(printer); break;
                case 3:
                    print = new LaserJet(); print.showPrint(printer); break;
                default:
                    Console.WriteLine("Maaf Printer tidak ditemukan!!!"); break;
            }
        }
    }
}