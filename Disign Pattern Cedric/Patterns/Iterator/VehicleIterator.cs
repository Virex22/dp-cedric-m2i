using Disign_Pattern_Cedric.Patterns.Iterator;
using Patterns.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Iterator
{
    class VehicleIterator : AbstractIterator<Vehicle>
    {
        private VehicleCatalogue catalogue;

        public VehicleIterator(VehicleCatalogue catalogue)
        {
            this.catalogue = catalogue;
        }

        public override bool End()
        {
            return position == catalogue.GetVehicles().Count;
        }

        public override Vehicle Item()
        {
            return catalogue.GetVehicles()[this.position];
        }
    }
}
