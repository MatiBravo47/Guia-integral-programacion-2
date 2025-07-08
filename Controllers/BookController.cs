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
        private List<Libro> bookList = new List<Libro>();

        public void MenuLibro()
        {
            var prestamoController = new PrestamoController();
            string opcionLibro;
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
                opcionLibro = Console.ReadLine();

                switch (opcionLibro)
                {
                    case "1":
                        Console.Clear();
                        var nuevoLibro = BookView.CreateBook();
                        AgregarLibro(nuevoLibro);
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Clear();
                        ListarLibros();
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Clear();
                        prestamoController.CreatePrestamo();
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.Clear();
                        prestamoController.ShowPrestamo();
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.Clear();
                        prestamoController.DeletePrestamo();
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
            bookList = ProductoRepository.Repository<Libro>.ObtenerTodos("books");
        }
        public void SaveBooks()
        {
            ProductoRepository.Repository<Libro>.GuardarLista("books", bookList);
        }
        public List<Libro> ListaLibros => bookList;
        public BookController()
        {
            LoadBooks();
        }
        public void AgregarLibro(Libro libro)
        {
            bookList.Add(libro);
            SaveBooks();
            Console.WriteLine("Libro agregado correctamente");
        }
        public void ListarLibros() 
        {
            BookView.MostrarLibros(ListaLibros);
        }
    }
}
