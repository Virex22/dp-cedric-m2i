using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Observer
{
    public class VehiclePriceView : Observer
    {
        protected Vehicle subject;

        public VehiclePriceView(Vehicle subject)
        {
            this.subject = subject;

            // first display
            Draw();
        }

        public void Notify()
        {
            Draw(); 
        }

        public void Draw()
        {
            Console.WriteLine("Car Price : " + subject.getPrice() + "euros ; Car Description : " + subject.getDescription());
        }
    }
}
