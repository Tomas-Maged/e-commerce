using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce
{
    public class CheckoutService
    {
        public CheckoutService(Customer customer, Cart cart)
        {
            
            Console.WriteLine("** Shipment notice **");
            double totalWeight = 0;
            foreach (var item in cart.Items)
            {
                
                if (item.Product.Weight > 0)
                {
                    Console.WriteLine($"{item.Quantity}x {item.Product.Name} {item.Product.Weight * 1000}g");
                    totalWeight += item.Product.Weight * item.Quantity;
                }
            }
            Console.WriteLine($"Total package weight {totalWeight}kg\n");

            
            Console.WriteLine("** Checkout receipt **");
            double subtotal = 0;
            foreach (var item in cart.Items)
            {
                Console.WriteLine($"{item.Quantity}x {item.Product.Name} {item.Product.Price * item.Quantity}");
                subtotal += item.Product.Price * item.Quantity;
            }
            Console.WriteLine("----------------------");
            double shipping = totalWeight > 0 ? 30 : 0;
            Console.WriteLine($"Subtotal {subtotal}");
            Console.WriteLine($"Shipping {shipping}");
            double amount = subtotal + shipping;
            Console.WriteLine($"Amount {amount}");
            customer.Balance -= amount;
            Console.WriteLine($"Remaining Balance: {customer.Balance}");
        }
    }
}
