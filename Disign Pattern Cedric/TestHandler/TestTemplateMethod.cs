using Patterns.TemplateMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHandler
{
    public class TestTemplateMethod : AbstractTestHandler
    {
        public TestTemplateMethod()
        {
            this.patternName = "TemplateMethod";
        }

        protected override void testPattern()
        {
            AbstractCommand command = new CommandFrance(100);
            Console.WriteLine("commande de 100 euros HT en france");
            command.calcTTC();
            command.Draw();

            Console.WriteLine("commande de 100 euros HT au luxembourg");
            command = new CommandLuxembourg(100);
            command.calcTTC();
            command.Draw();
        }
    }
}
