using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Strategy
{
    public class CatalogueView
    {
        IDrawCatalogueStrategy strategy;
        public CatalogueView(IDrawCatalogueStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void Draw(List<string> vehicleNames)
        {
            strategy.Draw(vehicleNames);
        }
    }
}
