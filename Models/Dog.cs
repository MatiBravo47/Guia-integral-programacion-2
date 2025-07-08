using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Dog : Animal
    {
        public Dog(string name) : base(name) { }
        
        public override string MakeSound()
        {
            return "Guau!";
        }

        public override string Introduce()
        {
            return $"Soy un perro llamado {Name} y hago {MakeSound()}";
        }
    }
}
