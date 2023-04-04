using Patterns.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHandler
{
    public class TestStrategy : AbstractTestHandler
    {
        public TestStrategy()
        {
            this.patternName = "Strategy";
        }

        protected override void testPattern()
        {
            Console.WriteLine("creation d'un catalogue avec une strategie un element par ligne");
            CatalogueView catalogue = new CatalogueView(new DrawOneVehicle());
            catalogue.Draw(this.getVehiclesList());
            Console.WriteLine("creation d'un catalogue avec une strategie trois element par ligne");
            catalogue = new CatalogueView(new DrawThreeVehicle());
            catalogue.Draw(this.getVehiclesList());
        }
        private List<string> getVehiclesList()
        {
            return new List<string>()
            {
                "voiture 1",
                "voiture 2",
                "voiture 3",
                "voiture 4",
                "voiture 5",
                "voiture 6",
                "voiture 7",
                "voiture 8",
                "voiture 9",
                "voiture 10",
            };
        }
    }
}
