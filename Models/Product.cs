using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        public Product() { }

        public Product(int id, string name, double price, int stock )
        {
            Id = id;
            Name = name;
            Price = price;
            Stock = stock;
        }
    }
}
