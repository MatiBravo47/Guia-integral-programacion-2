/*
Ejercicio 2: Herencia y Polimorfismo 
Narrativa: Estás desarrollando un software para una veterinaria que trabaja con diferentes tipos 
de animales. 
Consigna: 
1. 
Creá una clase base Animal con: 
○ Propiedad Nombre.  
○ Método virtual EmitirSonido(). 
2. 
Creá dos clases que hereden de Animal: 
○ Perro: sobreescribí EmitirSonido() devolviendo "Guau!" 
○ Gato: devolvé "Miau!" 
3. 
Agregá un método Presentarse() que devuelva por ejemplo: 
"Soy un gato llamado (nombre) y hago Miau!" 
Objetivo: Aplicar herencia, polimorfismo y sobrescritura de métodos.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Animal
    {
        public string Nombre { get; set; }

        public Animal() { }

        public Animal(string nombre) {
            Nombre = nombre;
        }

        public virtual string EmitirSonido() 
        {
            return "Sonido generico";
        }

        public virtual string Presentarse()
        {
            return $"Soy un animal llamado {Nombre} y hago {EmitirSonido()}";
        }
    }
}
