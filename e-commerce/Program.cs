using System;
namespace e_commerce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var cheese = new ExpirableProduct("Chesse" ,200,2,DateTime.Now.AddDays(3),5); 
            var biscuits = new ExpirableProduct("biscuits", 200, 2, DateTime.Now.AddDays(3),6); 
            var tv = new ShippableProduct("TV", 300, 3, 5); 
            var scratchCard = new NonExpirableNonShippableProduct("Scratch Card", 50,10);

            var customer = new Customer("John", 500);
            var cart = new Cart();

            cart.Add(cheese, 2);
            cart.Add(biscuits, 1);
            cart.Add(scratchCard, 1);

            CheckoutService checkoutService = new CheckoutService(customer, cart);
        }
    }
}
