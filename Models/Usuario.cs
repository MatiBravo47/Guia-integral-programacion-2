using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Email { get; set; }

        public Usuario() { }
        public Usuario(string nombre, string email) 
        {
            this.Nombre = nombre;
            this.Email = email;
        }
    }
}
