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

            var calculator = new InvoiceCalculator();
            var printer = new InvoicePrinter();
            var saver = new InvoiceSaver();

            double total = calculator.CalculateTotal();
            

            while (true)
            {
                Console.WriteLine("Como desea imprimir la factura?");
                Console.WriteLine("1. Papel");
                Console.WriteLine("2. Digital");
                Console.WriteLine("3. Salir");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1": Console.Clear(); printer.PrintOnPaper(); break;
                    case "2": Console.Clear(); printer.PrintDigital(); break;
                    case "3": return;
                    default: Console.WriteLine("Opcion incorrecta, presione una tecla para volver al menu"); break;
                }
                Console.WriteLine($"Total de la factura: {total}");
                saver.Save();
                Console.WriteLine("Presione una tecla para continuar...");
            }
        }
    }
}
