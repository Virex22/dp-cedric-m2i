using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Bridge
{
    public class FormImplementationApple : IFormImplementation
    {

        public void DrawText()
        {
            Console.WriteLine("<APPLE> Texte </APPLE>");
        }

        public void HandleInputZone()
        {
            Console.WriteLine("<APPLE> InputForm </APPLE>");
        }
    }
}
