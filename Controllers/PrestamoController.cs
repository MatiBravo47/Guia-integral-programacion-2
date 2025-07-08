using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;
using Models;
using Views;

namespace Controllers
{
    public class PrestamoController
    {
        private List<Prestamo> prestamosList = new List<Prestamo>();
        private UserController uController;
        private BookController bController;
        private List<Libro> listaLibros;

        public PrestamoController()
        {
            uController = new UserController();
            bController = new BookController();
            LoadPrestamos();
        }

        public void LoadPrestamos()
        {
            prestamosList = ProductoRepository.Repository<Prestamo>.ObtenerTodos("prestamos");
        }

        public void SavePrestamos() 
        {
            ProductoRepository.Repository<Prestamo>.GuardarLista("prestamos", prestamosList);
        }

        public void CreatePrestamo() 
        {
            var newUser = uController.CreateUser();

            bController.ListarLibros();

            PrestamoView.ShowMessage("Elija indice del libro a seleccionar");
            int seleccion = int.Parse(Console.ReadLine());
            var libroSeleccionado = bController.ListaLibros[seleccion];

            if (!libroSeleccionado.Disponibilidad) 
            {
                PrestamoView.ShowMessage("El libro seleccionado no esta disponible");
                return;
            }

            Prestamo newPrestamo = new Prestamo();

            newPrestamo.Libro = libroSeleccionado;
            newPrestamo.Usuario = newUser;
            newPrestamo.Fecha = DateTime.Now;

            libroSeleccionado.Disponibilidad = false;
            bController.SaveBooks();

            prestamosList.Add(newPrestamo);
            SavePrestamos();
            
            PrestamoView.ShowMessage("Préstamo registrado correctamente.");
        }

        public void ShowPrestamo()
        {
            int index = 0;
            foreach (var prestamo in prestamosList)
            {
                Console.WriteLine($"Indice: {index}");
                Console.WriteLine($"Usuario: {prestamo.Usuario.Nombre}, Fecha: {prestamo.Fecha}, Libro: {prestamo.Libro.Titulo}");
                index ++;
            }
        }

        public void DeletePrestamo()
        {
            ShowPrestamo();
            Console.WriteLine("Ingrese indice que desea eliminar");
            int indiceSeleccionado = int.Parse(Console.ReadLine());
            prestamosList.RemoveAt(indiceSeleccionado);
            SavePrestamos() ;
            Console.WriteLine("Prestamo eliminado");
        }
    }
}
