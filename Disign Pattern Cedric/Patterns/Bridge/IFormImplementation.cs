using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Bridge
{
    public interface IFormImplementation
    {
        public void DrawText();
        public void HandleInputZone();
    }
}
