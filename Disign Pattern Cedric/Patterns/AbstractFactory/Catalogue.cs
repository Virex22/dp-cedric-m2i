using Patterns.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory
{
    public class Catalogue
    {
        public ElectricVehicleFactory CreateElectricVehicleFactory()
        {
            return new ElectricVehicleFactory();
        }
        public FuelVehicleFactory CreateFuelVehicleFactory(){
            return new FuelVehicleFactory();
        }
    }
}
