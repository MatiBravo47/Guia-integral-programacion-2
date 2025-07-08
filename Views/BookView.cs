using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Views
{
    public class BookView
    {
        public static Libro CreateBook() 
        {
            Console.WriteLine("Creando nuevo libro");
            Console.Write("Titulo: ");
            string name = Console.ReadLine();
            Console.Write("Autor: ");
            string autor = Console.ReadLine();
            Console.Write("ISBN: ");
            string ISBN = Console.ReadLine();
            Boolean disponibilidad = true;
            return new Libro(name, autor, ISBN, disponibilidad);
        }

        public static void MostrarLibros(List<Libro> libros)
        {
            if (libros == null || libros.Count == 0)
            {
                Console.WriteLine("No hay libros registrados.");
                return;
            }
            int index = 0;
            Console.WriteLine("=== Lista de libros ===");
            Console.WriteLine("{0,-6} {1,-35} {2,-30} {3,-15} {4,-12}", "Índice", "Título", "Autor", "ISBN", "Disponible");
            Console.WriteLine(new string('-', 100));
            //Console.WriteLine("Indice Titulo                     Autor           ISBN            Disponible  ");
            //Console.WriteLine("--------------------------------");
            foreach (var libro in libros)
            {
                Console.WriteLine("{0,-6} {1,-35} {2,-30} {3,-15} {4,-12}",index, libro.Titulo, libro.Autor, libro.ISBN, libro.Disponibilidad);
                index++;
            }
        }

    }
}
