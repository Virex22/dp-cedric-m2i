using Patterns.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHandler
{
    public class TestSingleton : AbstractTestHandler
    {
        public TestSingleton()
        {
            this.patternName = "Singleton";
        }

        protected override void testPattern()
        {
            Console.WriteLine("add and remove doc1");
            SingletonLiasse.getInstance().Add("doc1");
            SingletonLiasse.getInstance().Remove("doc1");
            Console.WriteLine("instance id : " + SingletonLiasse.getInstance().GetHashCode());
            Console.WriteLine("instance id : " + SingletonLiasse.getInstance().GetHashCode());
        }
    }
}
