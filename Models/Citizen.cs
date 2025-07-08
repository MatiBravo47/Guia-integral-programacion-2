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
    public class Citizen
    {
        public string FullName { get; set; }
        public string DNI { get; set; }
        private int age;
        public int Age
        {
            get => age;
            set 
            {
                if (value < 0)
                    throw new ArgumentException("La edad no puede ser negativa");
                age = value;
            }
        }
        public Citizen() { }
        
        public Citizen(string fullName, string dni, int age) {
            FullName = fullName;
            DNI = dni;
            Age = age;
        }

        public bool IsAdult() {
            return Age >= 18;
        }

        public string Greet() {
            return $"Hola, mi nombre es {FullName} y tengo {Age} años";
        }

        public string ShowAdultStatus()
        {
            if (IsAdult())
                return $"{FullName} es mayor de edad ({Age})";
            else
                return $"{FullName} es menor de edad ({Age})";
        }
    }
}
