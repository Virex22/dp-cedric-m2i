using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory
{
    public class ScooterFuel : Scooter
    {
        public override void FillUp()
        {
            Console.WriteLine("Filling up the scooter with fuel");
        }

        public ScooterFuel(string name) : base(name)
        {
        }
    }
}
