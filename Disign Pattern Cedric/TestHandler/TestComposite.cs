using Patterns.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHandler
{
    public class TestComposite : AbstractTestHandler
    {
        public TestComposite()
        {
            this.patternName = "Composite";
        }

        protected override void testPattern()
        {
            Console.WriteLine("Creation d'une entreprise sans filiale");
            CompanyWithoutBranch companyWithoutBranch = new CompanyWithoutBranch();
            companyWithoutBranch.AddVehicle("Voiture");
            companyWithoutBranch.AddVehicle("Truck");
            companyWithoutBranch.AddVehicle("Bus");
            Console.WriteLine("Le cout de maintenance de l'entreprise est de " + companyWithoutBranch.CalculateMaintenanceCost() + " euros");

            Console.WriteLine("Creation d'une entreprise avec une filiale");
            CompanyWithBranch companyWithBranch = new CompanyWithBranch();
            companyWithBranch.AddVehicle("Voiture");
            companyWithBranch.AddVehicle("Truck");
            companyWithBranch.AddVehicle("Bus");
            CompanyWithoutBranch branch = new CompanyWithoutBranch();
            branch.AddVehicle("Voiture");
            branch.AddVehicle("Truck");
            branch.AddVehicle("Bus");
            companyWithBranch.AddBranch(branch);
            Console.WriteLine("Le cout de maintenance de l'entreprise est de " + companyWithBranch.CalculateMaintenanceCost() + " euros");
        }
    }
}
