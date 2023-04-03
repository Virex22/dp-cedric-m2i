using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory
{
    public class CarElectric : Car
    {
        public override void FillUp()
        {
            Console.WriteLine("Charging the car with electricity");
        }

        public CarElectric(string name) : base(name)
        {
        }
    }
}
