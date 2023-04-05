using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Builder
{
    public class SellerDirector
    {
        public Bundle ConstructBundleHTML()
        {
            BuilderVehicleBundleHTML builder = new BuilderVehicleBundleHTML();
            builder.ConstructPurchaseOrder();
            builder.ConstructImmatriculation();
            return builder.Result();
        }
        public Bundle ConstructBundlePDF()
        {
            BuilderVehicleBundlePDF builder = new BuilderVehicleBundlePDF();
            builder.ConstructPurchaseOrder();
            builder.ConstructImmatriculation();
            return builder.Result();
        }
    }
}
