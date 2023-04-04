using Patterns.Facade.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Facade
{
    public class WebServiceCarFacade
    {
        public void showCarPrice(string name)
        {
            List<string> cars = new ComponentCatalogue().getCarNames();
            if (!cars.Contains(name))
            {
                Console.WriteLine("La voiture " + name + " n'est pas disponible");
                return;
            }
            int price = new ComponentPriceCalculation().priceCalculation(name);
            string view = new ComponentDisplayCar().displayHTML(name,price);
            Console.WriteLine(view);
        }
    }
}
