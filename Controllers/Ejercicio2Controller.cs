using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class Ejercicio2Controller
    {
        public void EjecutarEjercicio2() 
        {
            Console.Title = "Herencia y Polimorfismo";

            var dog1 = new Dog("Leila");
            var cat1 = new Cat("Luke");

            Console.WriteLine(dog1.Introduce());
            Console.WriteLine(cat1.Introduce());

            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}
