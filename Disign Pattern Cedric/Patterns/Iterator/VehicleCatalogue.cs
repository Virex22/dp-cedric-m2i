using Patterns.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Iterator
{
    internal class VehicleCatalogue : AbstractCatalogue<Vehicle, VehicleIterator>
    {
        private List<Vehicle> vehicles;
                                                                              
        public override VehicleIterator Search()
        {
            VehicleIterator iterator = new VehicleIterator(this);
            return iterator;
            
        }

        public void setVehicleList(List<Vehicle> vehicles)
        {
            this.vehicles = vehicles;
        }
        
        public List<Vehicle> GetVehicles()
        {
            return vehicles;
        } 
    }
}
