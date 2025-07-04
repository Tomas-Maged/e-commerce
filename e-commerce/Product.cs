using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public Double Weight { get; set; }

        public Product(string name, double price, int quantity, double weight)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            Weight = weight;
        }

        public override string ToString()
        {
            return $"{Name} - ${Price} (Quantity: {Quantity} - {Weight}";
        }
    }
}
