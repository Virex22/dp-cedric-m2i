using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory
{
    public class ScooterElectric : Scooter
    {
        public override void FillUp()
        {
            Console.WriteLine("Charging the scooter with electricity");
        }

        public ScooterElectric(string name) : base(name)
        {
        }
    }
}
