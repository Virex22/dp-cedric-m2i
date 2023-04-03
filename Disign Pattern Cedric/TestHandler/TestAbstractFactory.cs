using Patterns.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestHandler;

namespace TestHandler
{
    public class TestAbstractFactory : AbstractTestHandler
    {
        public TestAbstractFactory()
        {
            this.patternName = "AbstractFactory";
        }

        protected override void testPattern()
        {
            Car electricCar = new Catalogue().CreateElectricVehicleFactory().CreateCar("tuture");
            Scooter fuelScooter = new Catalogue().CreateFuelVehicleFactory().CreateScooter("scooty");

            Console.WriteLine("test de la voiture electrique (on remet du carburant et on part !)");
            electricCar.FillUp();
            electricCar.Drive();

            Console.WriteLine("test du scooter à essence (on remet du carburant et on part !)");
            fuelScooter.FillUp();
            fuelScooter.Drive();
        }
    }
}
