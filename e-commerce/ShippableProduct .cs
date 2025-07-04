using e_commerce.InterFace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce
{
    public class ShippableProduct : Product , IShippable
    {
        public double Weight { get; set; }
        public ShippableProduct(string name, double price, int quantity, double weight)
            : base(name, price, quantity ,weight)
        {
            Weight = weight;
        }
        public string GetName()
        {
            return Name;
        }
        public double GetWight()
        {
            return Weight;
        }
        public override string ToString()
        {
            return $"{base.ToString()} - Weight: {Weight} kg";
        }
    }
}
