using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Facade.Component
{
    public class ComponentPriceCalculation
    {
        public void UseLessFunction1()
        {
            Console.WriteLine("UseLess");
        }
        public void UseLessFunction2()
        {
            Console.WriteLine("UseLess");
        }
        public void UseLessFunction3()
        {
            Console.WriteLine("UseLess");
        }

        public int priceCalculation(string name)
        {
            int price = 0;
            price += name.Length * 100;
            price += name.Split('0').Length * 1000;
            return price;
        }
    }
}
