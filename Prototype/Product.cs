using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Product(string name, decimal price, string category): IProductPrototype
    {
        public string Name { get; set; } = name;
        public decimal Price { get; set; } = price;
        public string Category { get; set; } = category;

        // Implement Clone()

        public IProductPrototype Clone()
        {
            // Shallow copy (MemberwiseClone)
            return (IProductPrototype)this.MemberwiseClone();
        }

        public override string ToString()
        {
            return $"{Name} ({Category}) - {Price:C}";
        }
    }
}
