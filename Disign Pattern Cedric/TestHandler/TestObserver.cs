using Patterns.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHandler
{
    public class TestObserver : AbstractTestHandler
    {
        public TestObserver()
        {
            this.patternName = "Observer";
        }

        protected override void testPattern()
        {
            Vehicle vehicle = new Vehicle();
            VehiclePriceView vehiclePriceView = new VehiclePriceView(vehicle);
            Console.WriteLine("changement du prix à 2000€");
            vehicle.setPrice(2000);
            Console.WriteLine("ajout de l'observateur");
            vehicle.AddObserver(vehiclePriceView);
            Console.WriteLine("changement du prix à 1500€");
            vehicle.setPrice(1500);
            Console.WriteLine("changement de la description");
            vehicle.setDescription("Voiture pas terrible");
        }
    }
}
