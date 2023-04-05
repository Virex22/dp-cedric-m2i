using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Builder
{
    abstract public class BuilderVehicleBundle
    {
        protected Bundle bundle;

        abstract public void ConstructPurchaseOrder();
        abstract public void ConstructImmatriculation();
        public Bundle Result()
        {
            return bundle;
        }
    }
}
