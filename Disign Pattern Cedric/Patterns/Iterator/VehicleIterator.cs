using Patterns.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Iterator
{
    public class VehicleIterator : AbstractIterator<Vehicle>
    {
        public VehicleIterator(AbstractCatalogue<Vehicle, AbstractIterator<Vehicle>> catalogue) : base(catalogue)
        {
        }

        public override bool End()
        {
            return position == ((VehicleCatalogue)this.catalogue).GetVehicles().Count;
        }

        public override Vehicle Item()
        {
            return this.catalogue.GetVehicles()[this.position];
        }
    }
}
