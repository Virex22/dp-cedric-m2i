using Patterns.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHandler
{
    public class TestFacade : AbstractTestHandler
    {
        public TestFacade()
        {
            this.patternName = "Facade";
        }

        protected override void testPattern()
        {
            Console.WriteLine("affichage du prix de la voiture Peugot 208");
            WebServiceCarFacade facade = new WebServiceCarFacade();
            facade.showCarPrice("Peugot 208");
            Console.WriteLine("affichage du prix de la voiture Peugot 20008");
            facade.showCarPrice("Peugot 20008");
            Console.WriteLine("affichage du prix de la voiture Renault 208");
            facade.showCarPrice("Renault 208");

        }
    }
}
