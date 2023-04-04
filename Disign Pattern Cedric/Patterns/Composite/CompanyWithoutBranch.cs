using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Composite
{
    class CompanyWithoutBranch : AbstractCompany
    {
        public override int CalculateMaintenanceCost()
        {
            int maintenanceCost = 0;
            foreach (string vehicle in vehicles)
            {
                maintenanceCost += 100;
                Console.WriteLine("100e pour entreprise : " + vehicle);
            }
            return maintenanceCost;
        }
    }
}
