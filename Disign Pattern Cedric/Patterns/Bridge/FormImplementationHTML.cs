using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Bridge
{
    public class FormImplementationHTML : IFormImplementation
    {
        public void DrawText()
        {
            Console.WriteLine("<HTML> Texte </HTML>");
        }

        public void HandleInputZone()
        {
            Console.WriteLine("<HTML> InputForm </HTML>");
        }
    }
}
