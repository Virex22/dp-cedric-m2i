using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory
{
    public class ElectricVehicleFactory : VehicleFactoryInterface
    {
        public Car CreateCar(string name)
        {
            return new CarElectric(name);
        }

        public Scooter CreateScooter(string name)
        {
            return new ScooterElectric(name);
        }
    }
}
