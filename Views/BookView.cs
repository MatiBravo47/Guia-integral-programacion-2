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
        public static Book CreateBook() 
        {
            Console.WriteLine("Creando nuevo libro");
            Console.Write("Titulo: ");
            string title = Console.ReadLine();
            Console.Write("Autor: ");
            string author = Console.ReadLine();
            Console.Write("ISBN: ");
            string ISBN = Console.ReadLine();
            Boolean available = true;
            return new Book(title, author, ISBN, available);
        }

        public static void ShowBooks(List<Book> books)
        {
            if (books == null || books.Count == 0)
            {
                Console.WriteLine("No hay libros registrados.");
                return;
            }
            int index = 0;
            Console.WriteLine("=== Lista de libros ===");
            Console.WriteLine("{0,-6} {1,-35} {2,-30} {3,-15} {4,-12}", "Índice", "Título", "Autor", "ISBN", "Disponible");
            Console.WriteLine(new string('-', 100));
            foreach (var book in books)
            {
                Console.WriteLine("{0,-6} {1,-35} {2,-30} {3,-15} {4,-12}",index, book.Title, book.Author, book.ISBN, book.Available);
                index++;
            }
        }

    }
}
