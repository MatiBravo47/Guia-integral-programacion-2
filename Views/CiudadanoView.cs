using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Views
{
    public class CiudadanoView
    {
        public static int PedirEdadValida()
        {
            while (true)
            {
                Console.Write("Ingrese edad: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int edad))
                {
                    if (edad >= 0)
                        return edad;
                    else
                        Console.WriteLine("La edad no puede ser negativa. Intente nuevamente.");
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un número válido.");
                }
            }
        }
        public static Ciudadano CrearCiudadano()
        {
            Console.Write("Ingrese nombre completo: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese DNI: ");
            string dni = Console.ReadLine();

            int edad = PedirEdadValida();
            Console.Clear();
            return new Ciudadano(nombre, dni, edad);
        }
    }
}
