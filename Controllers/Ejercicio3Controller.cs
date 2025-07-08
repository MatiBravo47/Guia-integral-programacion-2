using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace Controllers
{
    public class Ejercicio3Controller
    {
        public void EjecutarEjercicio3() 
        {
            Console.Title = "Principios SOLID";

            var calculadora = new FacturaCalculator();
            var impresora = new FacturaPrinter();
            var guardador = new FacturaSaver();

            double total = calculadora.CalcularTotal();
            

            while (true)
            {
                Console.WriteLine("Como desea imprimir la factura?");
                Console.WriteLine("1. Papel");
                Console.WriteLine("2. Digital");
                Console.WriteLine("3. Salir");

                string opcion3 = Console.ReadLine();

                switch (opcion3)
                {
                    case "1": Console.Clear(); impresora.ImprimirEnPapel(); break;
                    case "2": Console.Clear(); impresora.ImprimirDigital(); break;
                    case "3": return;
                    default: Console.WriteLine("Opcion incorrecta, presione una tecla para volver al menu"); break;
                }
                Console.WriteLine($"Total de la factura: {total}");
                guardador.Guardar();
                Console.WriteLine("Presione una tecla para continuar...");
            }
        }
    }
}
