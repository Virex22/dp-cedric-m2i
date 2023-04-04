using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Strategy
{
    public interface IDrawCatalogueStrategy
    {
        public void Draw(List<string> vehicleNames);
    }
}
