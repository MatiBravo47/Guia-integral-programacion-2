using Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Views;

namespace Controllers
{
    public class ProductController
    {
        private List<Product> productList = new List<Product>();

        public void ProductMenu()
        {
            Console.Title = "CRUD + JSON + Repository";
            string option;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Gestión de Productos");
                Console.WriteLine("1. Agregar nuevo producto");
                Console.WriteLine("2. Eliminar producto");
                Console.WriteLine("3. Modificar un producto");
                Console.WriteLine("4. Mostrar todos los productos");
                Console.WriteLine("5. Volver");
                option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.Clear(); CreateProduct(); Console.ReadKey(); break;
                    case "2":
                        Console.Clear(); DeleteProductByIndex(); Console.ReadKey(); break;
                    case "3":
                        Console.Clear(); UpdateProductByIndex(); Console.ReadKey(); break;
                    case "4":
                        Console.Clear(); ShowProducts(); Console.ReadKey(); break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Opción incorrecta, presione una tecla para volver al menú"); Console.ReadKey();
                        break;
                }
            }
        }

        public void LoadProducts()
        {
            productList = ProductoRepository.Repository<Product>.ObtenerTodos("products");
        }

        public void SaveProducts()
        {
            ProductoRepository.Repository<Product>.GuardarLista("products", productList);
        }

        public ProductController() {
            LoadProducts();
        }

        //CRUD

        public void CreateProduct()
        {
            Product newProduct = ProductView.CreateProduct();
            productList.Add(newProduct);
            SaveProducts();
            Console.WriteLine("Producto agregado correctamente");
        }

        public void ShowProducts()
        {
            int index = 0;
            if (productList.Count == 0)
            {
                Console.WriteLine("No hay productos registrados para mostrar.");
                return;
            }
            Console.WriteLine("Lista de productos:");
            foreach (var product in productList)
            {
                Console.WriteLine($"Indice: {index}");
                ProductView.ShowProduct(product);
                index++;
            }
            //Console.WriteLine("Presione una tecla para continuar...");
        }

        public void UpdateProductByIndex()
        {
            if (productList.Count == 0)
            {
                Console.WriteLine("No hay productos registrados para actualizar.");
                return;
            }
            ShowProducts();
            Console.WriteLine("Ingrese indice a actualizar");
            int indexUpdate = int.Parse(Console.ReadLine());
            if (indexUpdate < 0 || indexUpdate >= productList.Count)
            {
                Console.WriteLine("Índice inválido.");
                return;
            }
            Product newProduct = ProductView.CreateProduct();
            productList[indexUpdate] = newProduct; 
            SaveProducts();
            Console.WriteLine("Producto actualizado!");
        }

        public void DeleteProductByIndex()
        {
            if (productList.Count == 0)
            {
                Console.WriteLine("No hay productos registrados para eliminar.");
                return;
            }
            ShowProducts();
            Console.WriteLine("Ingrese index de producto a eliminar");
            int indexDelete = int.Parse(Console.ReadLine());
            if (indexDelete < 0 || indexDelete >= productList.Count)
            {
                Console.WriteLine("Índice inválido.");
                return;
            }
            productList.RemoveAt(indexDelete);
            SaveProducts();
            Console.WriteLine("Producto eliminado!");
        }
    }
}
