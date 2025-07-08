using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Views
{
    public class ProductView
    {
        public static Product CreateProduct() 
        {
            int id, stock;
            double price;
            string name;

            while (true)
            {
                try
                {
                    Console.Write("Ingrese ID: ");
                    if (!int.TryParse(Console.ReadLine(), out id))
                        throw new FormatException("El ID debe ser un numero entero.");

                    Console.Write("Ingrese nombre: ");
                    name = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(name))
                        throw new FormatException("El nombre no puede estar vacio.");

                    Console.Write("Precio: ");
                    if (!double.TryParse(Console.ReadLine(), out price))
                        throw new FormatException("El precio debe ser un numero decimal.");

                    Console.Write("Stock: ");
                    if (!int.TryParse(Console.ReadLine(), out stock))
                        throw new FormatException("El stock debe ser un numero entero.");

                    break; // Si todo es válido, salimos del bucle
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Error: {ex.Message} Intente nuevamente.");
                }
            }

            return new Product(id, name, price, stock);
        }

        public static void ShowProduct(Product product)
        {
            Console.WriteLine($"ID: {product.Id}, nombre: {product.Name}, precio: {product.Price}, stock: {product.Stock}");
        }
    }
}
