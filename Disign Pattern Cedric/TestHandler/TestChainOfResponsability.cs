using Patterns.ChainOfResponsibility;
using Patterns.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHandler
{
    public class TestChainOfResponsability : AbstractTestHandler
    {
        public TestChainOfResponsability()
        {
            this.patternName = "ChainOfResponsability";
        }

        protected override void testPattern()
        {
            Console.WriteLine("test with all description");
            BasicObject basicObject = new Vehicle("Peugot 2008 avec climatisation",
                new Model("Peugot 2008",
                    new Mark("Peugot")
                )
             );
            Console.WriteLine(basicObject.giveDescription());

            Console.WriteLine("test with model and mark description");
            basicObject = new Vehicle(null,
                new Model("Peugot 2008",
                    new Mark("Peugot")
                )
             );
            Console.WriteLine(basicObject.giveDescription());
            Console.WriteLine("test with mark description");
            basicObject = new Vehicle(null,
                new Model(null,
                    new Mark("Peugot")
                )
             );
            Console.WriteLine(basicObject.giveDescription());
        }
    }
}
                                                                    