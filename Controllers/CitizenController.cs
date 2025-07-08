using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Views;

namespace Controllers
{
    public class CitizenController
    {
        public void EjecutarEjercicio1() 
        {
            Console.Title = "Fundamentos de POO";

            var citizen1 = new Citizen("Juan Perez", "12345678", 25);
            var citizen2 = new Citizen("Marta Lopez", "12345678", 16);
            var citizen3 = CitizenView.CreateCitizen();

            Console.WriteLine(citizen1.Greet());
            Console.WriteLine(citizen2.Greet());
            Console.WriteLine(citizen3.Greet());

            Console.WriteLine(citizen1.ShowAdultStatus());
            Console.WriteLine(citizen2.ShowAdultStatus());
            Console.WriteLine(citizen3.ShowAdultStatus());

            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();

        }

    }
}
