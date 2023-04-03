using Patterns.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHandler
{
    public class TestIterator : AbstractTestHandler
    {
        public TestIterator()
        {
            this.patternName = "Iterator";
        }

        protected override void testPattern()
        {
            VehicleCatalogue catalogue = new VehicleCatalogue();
            VehicleIterator iterator = catalogue.Search();
            catalogue.setVehicleList(getVehicleList());
            while (!iterator.End())
            {
                Console.WriteLine(iterator.Item().GetInfo());
                iterator.Next();
            }
        }

        static private List<Vehicle> getVehicleList()
        {
            return new List<Vehicle>()
            {
               new Vehicle("tesla model X"),
               new Vehicle("Peugot 208"),
               new Vehicle("Citroen C3"),
               new Vehicle("Volkswagen Polo")
            };
        }
    }
}
