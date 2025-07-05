using e_commerce.InterFace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce
{
    public class ExpirableProduct : Product, IExpirable
    {
        public DateTime ExpirationDate { get; set; }

        
        public double Weight { get; set; }

        public ExpirableProduct(string name, double price, int quantity, DateTime expirationDate, double weight = 0)
            : base(name, price, quantity, weight)
        {
            ExpirationDate = expirationDate;
            Weight = weight;
        }

        public bool IsExpired()
        {
            return DateTime.Now > ExpirationDate;
        }

        public override string ToString()
        {
            return $"{Name} {Weight * 1000}g";
        }
    }
}

