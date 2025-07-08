/*Ejercicio 1: Fundamentos de POO 
Narrativa: La municipalidad local te ha contratado para desarrollar un pequeño sistema de 
gestión de ciudadanos para su base de datos. 
Consigna: Desarrollá una clase Ciudadano que contenga: 
● Nombre completo(string)
● DNI(string)
● Edad(int)
● Método Saludar() que devuelva un string personalizado con el nombre y edad del 
ciudadano. 
Extras sugeridos: 
● Validá que la edad sea mayor o igual a 0. 
● Agregá un método que indique si el ciudadano es mayor de edad. 
Objetivo: Practicar encapsulamiento, métodos, constructores y lógica básica.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Ciudadano
    {
        public string NombreCompleto { get; set; }
        public string DNI { get; set; }
        private int edad;
        public int Edad
        {
            get => edad;
            set 
            {
                if (value < 0)
                    throw new ArgumentException("La edad no puede ser negativa");
                edad = value;
            }
        }
        //Constructor vacio
        public Ciudadano() { }
        
        //Constructor completo
        public Ciudadano(string nombreCompleto, string dni, int edad) {
            NombreCompleto = nombreCompleto;
            DNI = dni;
            Edad = edad;
        }

        public bool MayorEdad() {
            return Edad >= 18;
        }

        public string Saludar() {
            return $"Hola, mi nombre es {NombreCompleto} y tengo {Edad} años";
        }

        public string MostrarEstadoMayorEdad()
        {
            if (MayorEdad())
                return $"{NombreCompleto} es mayor de edad ({Edad})";
            else
                return $"{NombreCompleto} es menor de edad ({Edad})";
        }
    }
}
