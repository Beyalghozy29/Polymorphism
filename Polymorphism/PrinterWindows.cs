using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class PrinterWindows
    {
        public string name { get; set; }

        public virtual void Show()
        {
            Console.WriteLine("Pilihan Printer");
        }

        public virtual void Print()
        {
            Console.WriteLine("Pilihan Printer");
        }
    }
}