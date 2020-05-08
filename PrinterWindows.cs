using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class PrinterWindows
    {
        public virtual void Show()
        {
            Console.WriteLine("\nPrinter display dimension");
        }
        public virtual void Print()
        {
            Console.WriteLine("Printer printing");
        }
    }
}
