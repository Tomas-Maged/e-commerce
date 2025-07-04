using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce
{
    public class NonExpirableNonShippableProduct : Product
    {
        public NonExpirableNonShippableProduct(string name, double price, int quantity)
           : base(name, price, quantity, 0)
        {
        }
    }
}
