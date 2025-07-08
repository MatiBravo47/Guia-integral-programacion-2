using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Cat : Animal 
    {
        public Cat(string name) : base(name) { }

        public override string MakeSound()
        {
            return "Miau";
        }

        public override string Introduce()
        {
            return $"Soy un gato llamado {Name} y hago {MakeSound()}";
        }
    }
}
