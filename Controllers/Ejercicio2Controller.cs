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

            var perro1 = new Perro("Leila");
            var gato1 = new Gato("Luke");

            Console.WriteLine(perro1.Presentarse());
            Console.WriteLine(gato1.Presentarse());

            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}
