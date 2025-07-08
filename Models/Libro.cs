using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string ISBN { get; set; }
        public Boolean Disponibilidad { get; set; }

        public Libro() { }
        public Libro(string titulo, string autor, string iSBN, bool disponibilidad)
        {
            Titulo = titulo;
            Autor = autor;
            ISBN = iSBN;
            Disponibilidad = disponibilidad;
        }
    }
}
