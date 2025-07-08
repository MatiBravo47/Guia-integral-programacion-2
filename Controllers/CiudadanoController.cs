using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Views;

namespace Controllers
{
    public class CiudadanoController
    {
        public void EjecutarEjercicioCiudadano() 
        {
            Console.Title = "Fundamentos de POO";

            var ciudadano1 = new Ciudadano("Juan Perez", "12345678", 25);
            var ciudadano2 = new Ciudadano("Marta Lopez", "12345678", 16);
            var ciudadano3 = CiudadanoView.CrearCiudadano();

            Console.WriteLine(ciudadano1.Saludar());
            Console.WriteLine(ciudadano2.Saludar());
            Console.WriteLine(ciudadano3.Saludar());

            Console.WriteLine(ciudadano1.MostrarEstadoMayorEdad());
            Console.WriteLine(ciudadano2.MostrarEstadoMayorEdad());
            Console.WriteLine(ciudadano3.MostrarEstadoMayorEdad());

            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();

        }

    }
}
