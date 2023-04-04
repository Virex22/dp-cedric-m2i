using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Composite
{
    abstract class AbstractCompany
    {
        protected List<string> vehicles = new List<string>();

        public void AddVehicle(string vehicleName)
        {
            vehicles.Add(vehicleName);
        }

        abstract public int CalculateMaintenanceCost();
    }
}
