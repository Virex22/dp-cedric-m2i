using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Flyweight
{
    public class FactoryOption
    {
        Dictionary<string, VehicleOption> options = new Dictionary<string, VehicleOption>();

        public VehicleOption GetOption(string name, float price)
        {
            if (options.ContainsKey(name))
                return options[name];

            VehicleOption newOption = new VehicleOption(name,price);
            options.Add(name, newOption);
            return newOption;
        }
    }
}
