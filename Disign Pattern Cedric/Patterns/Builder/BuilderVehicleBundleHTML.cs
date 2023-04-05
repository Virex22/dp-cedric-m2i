using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Builder
{
    public class BuilderVehicleBundleHTML : BuilderVehicleBundle
    {
        public override void ConstructImmatriculation()
        {
            if (this.bundle == null)
            {
                this.bundle = new BundleHTML();
            }
            this.bundle.AddDocument("Immatriculation");
        }

        public override void ConstructPurchaseOrder()
        {
            if (this.bundle == null)
            {
                this.bundle = new BundleHTML();
            }
            this.bundle.AddDocument("PurchaseOrder");
        }
    }
}
