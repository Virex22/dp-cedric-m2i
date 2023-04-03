using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Decorator
{
    abstract public class VehicleViewDecorator : IVehicleGraphicComponent
    {
        protected IVehicleGraphicComponent component;

        public VehicleViewDecorator(IVehicleGraphicComponent component)
        {
            this.component = component;
        }

        abstract public void Show();
    }
}
