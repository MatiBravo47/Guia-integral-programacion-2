using Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Views;

namespace Controllers
{
    public class BookController
    {
        private List<Book> bookList = new List<Book>();

        public void BookMenu()
        {
            var loanController = new LoanController();
            string bookOption;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Gestión de Libros");
                Console.WriteLine("1. Agregar libro");
                Console.WriteLine("2. Listar libros");
                Console.WriteLine("3. Crear préstamo (Pedir libro)");
                Console.WriteLine("4. Listar préstamos");
                Console.WriteLine("5. Eliminar préstamo (Devolver libro)");
                Console.WriteLine("6. Volver");
                Console.Write("Seleccione una opción: ");
                bookOption = Console.ReadLine();

                switch (bookOption)
                {
                    case "1":
                        Console.Clear();
                        var newBook = BookView.CreateBook();
                        AddBook(newBook);
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Clear();
                        ListBooks();
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Clear();
                        loanController.CreateLoan();
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.Clear();
                        loanController.ShowLoans();
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.Clear();
                        loanController.DeleteLoan();
                        Console.ReadKey();
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Opción incorrecta.");
                        Console.ReadKey();
                        break;
                }
            }
        }
        public void LoadBooks()
        {
            bookList = ProductoRepository.Repository<Book>.ObtenerTodos("books");
        }
        public void SaveBooks()
        {
            ProductoRepository.Repository<Book>.GuardarLista("books", bookList);
        }
        public List<Book> BookList => bookList;
        public BookController()
        {
            LoadBooks();
        }
        public void AddBook(Book book)
        {
            bookList.Add(book);
            SaveBooks();
            Console.WriteLine("Libro agregado correctamente");
        }
        public void ListBooks() 
        {
            BookView.ShowBooks(BookList);
        }
    }
}
