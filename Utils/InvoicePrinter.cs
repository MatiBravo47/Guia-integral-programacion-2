using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class InvoicePrinter : IPaperPrint, IDigitalPrint 
    {
        public void Print() 
        {
            Console.WriteLine("Impresion generica");
        }
        public void PrintOnPaper() 
        {
            Console.WriteLine("Imprimiento factura en papel");
        }

        public void PrintDigital() 
        {
            Console.WriteLine("Enviando factura por email..");
        }
    }
}
