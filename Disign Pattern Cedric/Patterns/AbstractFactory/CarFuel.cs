using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory
{
    class CarFuel : Car
    {
        public CarFuel(string name) : base(name)
        {
            
        }

        public override void FillUp()
        {
            Console.WriteLine("Filling up the car with fuel");
        }
    }
}
        
