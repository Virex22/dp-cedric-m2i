using Patterns.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory
{
    public interface VehicleFactoryInterface
    {
        public Car CreateCar(string name);
        public Scooter CreateScooter(string name);
    }
}
