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
    public class LoanController
    {
        private List<Loan> loanList = new List<Loan>();
        private UserController uController;
        private BookController bController;
        private List<Book> bookList;

        public LoanController()
        {
            uController = new UserController();
            bController = new BookController();
            LoadLoans();
        }

        public void LoadLoans()
        {
            loanList = ProductoRepository.Repository<Loan>.ObtenerTodos("loans");
        }

        public void SavePrestamos() 
        {
            ProductoRepository.Repository<Loan>.GuardarLista("loans", loanList);
        }

        public void CreateLoan() 
        {
            var newUser = uController.CreateUser();

            bController.ListBooks();

            PrestamoView.ShowMessage("Elija indice del libro a seleccionar");
            int seleccion = int.Parse(Console.ReadLine());
            var libroSeleccionado = bController.BookList[seleccion];

            if (!libroSeleccionado.Available) 
            {
                PrestamoView.ShowMessage("El libro seleccionado no esta disponible");
                return;
            }

            Loan newLoan = new Loan();

            newLoan.Book = libroSeleccionado;
            newLoan.User = newUser;
            newLoan.Date = DateTime.Now;

            libroSeleccionado.Available = false;
            bController.SaveBooks();

            loanList.Add(newLoan);
            SavePrestamos();
            
            PrestamoView.ShowMessage("Préstamo registrado correctamente.");
        }

        public void ShowLoans()
        {
            int index = 0;
            Console.WriteLine("==Lista de prestamos==");
            Console.WriteLine("{0,-6} {1,-35} {2,-20} {3,-35} {4,-12}",
    "Índice", "Usuario", "Fecha", "Titulo", "Disponible");
            foreach (var loan in loanList)
            {
                Console.WriteLine("{0,-6} {1,-35} {2,-20} {3,-35} {4,-12}", index, loan.User.Name, loan.Date, loan.Book.Title, loan.Book.Available);
                index ++;
            }
        }

        public void DeleteLoan()
        {
            ShowLoans();
            Console.WriteLine("Ingrese indice que desea eliminar");
            int indiceSeleccionado = int.Parse(Console.ReadLine());
            loanList.RemoveAt(indiceSeleccionado);
            SavePrestamos() ;
            Console.WriteLine("Prestamo eliminado");
        }
    }
}
