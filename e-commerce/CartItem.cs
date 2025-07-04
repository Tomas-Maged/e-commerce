using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce
{
    public class CartItem
    {
        public CartItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }

        public Product Product { get; }
        public int Quantity { get; }

        public double GetTotalPrice() => Product.Price * Quantity;

    }
}
