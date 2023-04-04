using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Strategy
{
    public class DrawOneVehicle : IDrawCatalogueStrategy
    {
        public void Draw(List<string> vehicleNames)
        {
            for (int i = 0; i < vehicleNames.Count; i++)
                Console.WriteLine(vehicleNames[i]);
        }
    }
}
