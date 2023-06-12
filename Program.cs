using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            PrinterWindows printer;
            Console.WriteLine("Pilih Printer :");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. Laserjett\n");
            Console.WriteLine("Nomer Printer : ");

            int nomornrinter = Convert.ToInt32(Console.ReadLine()); 
            if (nomornrinter == 1) 
                printer = new Epson();
            else if (nomornrinter == 2)
                printer = new Canon();
            else
                printer = new Laserjet();
            printer.show();
            printer.print();

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
