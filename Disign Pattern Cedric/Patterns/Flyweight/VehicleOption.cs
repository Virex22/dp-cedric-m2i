using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Flyweight
{
    public class VehicleOption
    {
        protected string name;
        protected float price;

        public VehicleOption(string name, float price)
        {
            this.name = name;
            this.price = price;
        }

        public void Show(float price)
        {
            float totalPrice = this.price + price;
            Console.WriteLine("[DEBUG] - Hash de l'option : " + this.GetHashCode());
            Console.WriteLine("  Name : " + this.name + " ; Price : " + totalPrice);
        }

        public string GetName()
        {
            return name;
        }
    }
}
