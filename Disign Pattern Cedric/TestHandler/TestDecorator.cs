using Patterns.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHandler
{
    public class TestDecorator : AbstractTestHandler
    {
        public TestDecorator()
        {
            this.patternName = "Decorator";
        }

        protected override void testPattern()
        {
            IVehicleGraphicComponent vehicleView = new ModelDecorator(new BrandDecorator(new VehicleView(), "Peugot"),"208");
            vehicleView.Show();
        }
    }
}
