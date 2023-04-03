using Patterns.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Decorator
{
    public class ModelDecorator : VehicleViewDecorator
    {
        protected string model;
        
        public ModelDecorator(IVehicleGraphicComponent component, string model) : base(component)
        {
            this.model = model;
        }

        public override void Show()
        {
            this.component.Show();
            ShowTechnicalInformation();
        }
        
        protected void ShowTechnicalInformation()
        {
            Console.WriteLine("Model : " + model);
        }
    }
}
