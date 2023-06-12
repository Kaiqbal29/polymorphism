using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    internal class PrinterWindows
    {
        public virtual void show()
        {
            Console.WriteLine("Printer Windows display dimension");
        }
        public virtual void print()
        {
            Console.WriteLine("Printer Windows printing");
        }
    }

    class Epson : PrinterWindows 
    {
        public override void print() 
        {
            Console.WriteLine(" Epson Printer printing...");
        }
        public override void show()
        {
            Console.WriteLine(" Epson display dimension: 10 * 11");
        }
    }
    class Canon : PrinterWindows
    {
        public override void print()
        {
            Console.WriteLine(" Canon Printer printing...");
        }
        public override void show()
        {
            Console.WriteLine(" Canon display dimension: 9.5 * 12");
        }
    }
    class Laserjet : PrinterWindows
    {
        public override void print()
        {
            Console.WriteLine(" Laserjett Printer printing...");
        }
        public override void show()
        {
            Console.WriteLine(" Laserjett display dimension: 12 * 12 ");
        }
    }
}
