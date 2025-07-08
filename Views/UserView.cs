using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Views
{
    public class UserView
    {
        public static Usuario CreateUser()
        {
            Console.WriteLine("Creando usuario");
            Console.Write("Nombre: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();

            return new Usuario(name, email);
        }

        public static void ShowUser(Usuario usuario) 
        {
            Console.WriteLine($"Nombre: {usuario.Nombre}, email: {usuario.Email}");
        }

    }
}
