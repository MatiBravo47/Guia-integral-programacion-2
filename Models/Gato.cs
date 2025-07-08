using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Gato : Animal 
    {
        public Gato(string nombre) : base(nombre) { }

        public override string EmitirSonido()
        {
            return "Miau";
        }

        public override string Presentarse()
        {
            return $"Soy un gato llamado {Nombre} y hago {EmitirSonido()}";
        }
    }
}
