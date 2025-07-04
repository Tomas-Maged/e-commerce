using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce
{
    public class Customer
    {
        public Customer(string name, double balance)
        {
            Name = name;
            Balance = balance;
        }

        public string Name { get; }
        public double Balance { get; set; }
    }
}
