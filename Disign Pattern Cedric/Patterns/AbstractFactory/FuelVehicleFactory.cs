using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory
{
    public class FuelVehicleFactory : VehicleFactoryInterface
    {
        public Car CreateCar(string name)
        {
            return new CarFuel(name);
        }

        public Scooter CreateScooter(string name)
        {
            return new ScooterFuel(name);
        }
    }
}
