using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Flyweight
{
    public class CarOrdered
    {
        protected float price;
        Dictionary<string,VehicleOption> options = new Dictionary<string,VehicleOption>();

        public CarOrdered(float price = 0)
        {
            this.price = price;
        }
        public void AddOption(string name, float price, FactoryOption factory)
        {
            VehicleOption option = factory.GetOption(name, price);
            options.Add(option.GetName(), option);
        }

        public void ShowOption()
        {
            foreach (VehicleOption option in options.Values.ToList())
            {
                option.Show(this.price);
            }
        }
    }
}
