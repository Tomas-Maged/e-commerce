using e_commerce.InterFace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce
{
    public class ShippingService
    {
        public static void Ship(List<IShippable> items)
        {
            if (items.Count == 0) return;

            Console.WriteLine("** Shipment notice **");
            double totalWeight = 0;
            var grouped = items.GroupBy(i => i.GetName());

            foreach (var group in grouped)
            {
                int count = group.Count();
                double weight = group.First().GetWight() * count;
                totalWeight += weight;
                Console.WriteLine($"{count}x {group.Key} {weight * 1000 / count}g");
            }

            Console.WriteLine($"Total package weight {totalWeight}kg\n");
        }

    }
}
