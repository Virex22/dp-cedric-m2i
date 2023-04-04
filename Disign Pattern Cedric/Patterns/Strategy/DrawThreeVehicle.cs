using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Strategy
{
    public class DrawThreeVehicle : IDrawCatalogueStrategy
    {
        public void Draw(List<string> vehicleNames)
        {
            for (int i = 0; i < vehicleNames.Count; i = i + 3)
            {
                string output = "";
                output = vehicleNames[i];
                if (i + 1 < vehicleNames.Count)
                    output += " | " + vehicleNames[i + 1];
                if (i + 2 < vehicleNames.Count)
                    output += " | " + vehicleNames[i + 2];
                Console.WriteLine(output);
            }
        }
    }
}
