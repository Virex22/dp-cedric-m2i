using Patterns.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHandler
{
    public class TestProxy : AbstractTestHandler
    {
        public TestProxy()
        {
            this.patternName = "Proxy";
        }

        protected override void testPattern()
        {
            Console.WriteLine("Click sur le film");
            AnimationProxy animation = new AnimationProxy();
            animation.Click();
            animation.Draw();
            Console.WriteLine("Autre click sur le film");
            animation.Click();
            animation.Draw();
        }
    }
}
