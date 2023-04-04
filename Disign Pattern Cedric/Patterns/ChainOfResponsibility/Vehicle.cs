using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.ChainOfResponsibility
{
    public class Vehicle : BasicObject
    {
        private string? name;
        public Vehicle(string? name, BasicObject? next = null) : base(next)
        {
            this.name = name;
        }

        protected override string? getDescription()
        {          
            if (this.name == null) 
                return null; 
            return "Vehicule : " + this.name;
        }
    }
}
