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
        public static User CreateUser()
        {
            Console.WriteLine("Creando usuario");
            Console.Write("Nombre: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();

            return new User(name, email);
        }

        public static void ShowUser(User user) 
        {
            Console.WriteLine($"Nombre: {user.Name}, email: {user.Email}");
        }

    }
}
