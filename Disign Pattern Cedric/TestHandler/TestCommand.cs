using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHandler
{
    public class TestCommand : AbstractTestHandler
    {
        public TestCommand()
        {
            this.patternName = "Command";
        }

        protected override void testPattern()
        {

        }
    }
}
