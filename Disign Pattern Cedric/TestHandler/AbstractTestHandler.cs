using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHandler
{
    abstract public class AbstractTestHandler
    {
        protected string patternName;

        public AbstractTestHandler()
        {
            this.patternName = "*NON RENSEIGNER*";
        }

        public void Handle()
        {
            Console.WriteLine("*----------------------------------*");
            Console.WriteLine("TEST PATTERN " + patternName.ToUpper()); 
            Console.WriteLine("*----------------------------------*");
            this.testPattern();
            Console.WriteLine("\r\n");
        }

        abstract protected void testPattern();
    }
}
