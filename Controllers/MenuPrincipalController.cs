using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class MenuPrincipalController
    {
        public void MostrarMenu()
        {
            Console.Title = "Guia integral programacion";
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Menú principal");
                Console.WriteLine("1. Fundamentos del POO");
                Console.WriteLine("2. Herencia y polimorfismo");
                Console.WriteLine("3. Principios SOLID");
                Console.WriteLine("4. Gestión de productos");
                Console.WriteLine("5. Gestión de libros");
                Console.WriteLine("6. Salir");
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Clear();
                        var ciudadanoController = new CiudadanoController();
                        ciudadanoController.EjecutarEjercicioCiudadano();
                        break;
                    case "2":
                        Console.Clear();
                        var ejercicio2Controller = new Ejercicio2Controller();
                        ejercicio2Controller.EjecutarEjercicio2();
                        break;
                    case "3":
                        Console.Clear();
                        var ejercicio3Controller = new Ejercicio3Controller();
                        ejercicio3Controller.EjecutarEjercicio3();
                        break;
                    case "4":
                        Console.Clear();
                        var productController = new ProductController();
                        productController.MenuProducto();
                        break;
                    case "5":
                        Console.Clear();
                        var bookController = new BookController();
                        bookController.MenuLibro();
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Opción inválida. Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
