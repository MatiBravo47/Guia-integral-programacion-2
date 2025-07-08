using Guia_integral_programacion.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class FacturaPrinter : IImpresionPapel, IImpresionDigital 
    {
        public void Imprimir() 
        {
            Console.WriteLine("Impresion generica");
        }
        public void ImprimirEnPapel() 
        {
            Console.WriteLine("Imprimiento factura en papel");
        }

        public void ImprimirDigital() 
        {
            Console.WriteLine("Enviando factura por email..");
        }
    }
}
