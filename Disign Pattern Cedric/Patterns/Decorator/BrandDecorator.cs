using Patterns.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Decorator
{
    public class BrandDecorator : VehicleViewDecorator
    {
        protected string brand;

        public BrandDecorator(IVehicleGraphicComponent component, string brand) : base(component)
        {
            this.brand = brand;
        }
        
        public void ShowBrand()
        {
            Console.WriteLine("Brand : " + brand);
        }

        public override void Show()
        {
            this.component.Show();
            this.ShowBrand();
        }
    }
}
