using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Composite
{
    class CompanyWithBranch : AbstractCompany
    {
        protected List<AbstractCompany> branchs = new List<AbstractCompany>();
        
        public override int CalculateMaintenanceCost()
        {
            int maintenanceCost = 0;
            foreach (string vehicle in vehicles)
            {
                maintenanceCost += 100;
                Console.WriteLine("100 entreprise mère : " + vehicle);
            }
            foreach (AbstractCompany branch in branchs)
            {
                maintenanceCost += branch.CalculateMaintenanceCost();
            }
            return maintenanceCost;
        }
                  
        public void AddBranch(AbstractCompany branch)
        {
            branchs.Add(branch);
        }
    }
}
