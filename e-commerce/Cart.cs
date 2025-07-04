using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce
{
    public class Cart
    {
        private List<CartItem> items = new();

        public IReadOnlyList<CartItem> Items => items;

        public void Add(Product product, int quantity)
        {
            if (quantity <= 0 || quantity > product.Quantity)
            {
                Console.WriteLine($"Error: Invalid quantity for {product.Name}");
                return;
            }

            items.Add(new CartItem(product, quantity));
        }

        public bool IsEmpty() => !items.Any();
    }
}
