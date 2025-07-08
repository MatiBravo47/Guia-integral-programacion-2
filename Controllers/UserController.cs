using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Views;
using Models;
using Views;

namespace Controllers
{
    public class UserController
    {
        public Usuario CreateUser() => UserView.CreateUser();

        public void ShowUsers(Usuario usuario) => UserView.ShowUser(usuario);
    }
}
