using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Facade.Component
{
    public class ComponentCatalogue
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
        public List<string> getCarNames()
        {
            return new List<string>() {
                "Peugot 208",
                "Peugot 2008",
                "Peugot 20008",
                "Peugot 200008",
            };
        }
    }
}
