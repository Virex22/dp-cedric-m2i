using Patterns.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Iterator
{
    public class Vehicle : AbstractElement
    {
        private string model;
        
        public Vehicle (string model)
        {
            this.name = "vehicle";
            this.model = model;
        }
        
        public override string GetInfo()
        {
            return "name : " + this.name + ", model : " + this.model;
        }
    }
}
