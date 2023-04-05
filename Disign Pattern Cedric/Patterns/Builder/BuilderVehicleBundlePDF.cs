using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Builder
{
    public class BuilderVehicleBundlePDF : BuilderVehicleBundle
    {
        public override void ConstructImmatriculation()
        {
            if (this.bundle == null)
            {
                this.bundle = new BundlePDF();
            }
            this.bundle.AddDocument("Immatriculation");
        }

        public override void ConstructPurchaseOrder()
        {
            if (this.bundle == null)
            {
                this.bundle = new BundlePDF();
            }
            this.bundle.AddDocument("PurchaseOrder");
        }
    }
}
