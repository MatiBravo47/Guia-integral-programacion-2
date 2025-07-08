using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Views
{
    public class CitizenView
    {
        public static int RequestValidAge()
        {
            while (true)
            {
                Console.Write("Ingrese edad: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int age))
                {
                    if (age >= 0)
                        return age;
                    else
                        Console.WriteLine("La edad no puede ser negativa. Intente nuevamente.");
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un número válido.");
                }
            }
        }
        public static Citizen CreateCitizen()
        {
            Console.Write("Ingrese nombre completo: ");
            string fullName = Console.ReadLine();

            Console.Write("Ingrese DNI: ");
            string dni = Console.ReadLine();

            int age = RequestValidAge();
            Console.Clear();
            return new Citizen(fullName, dni, age);
        }
    }
}
