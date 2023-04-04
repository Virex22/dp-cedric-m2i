using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.ChainOfResponsibility
{
    abstract public class BasicObject
    {
        protected BasicObject? next;

        public BasicObject(BasicObject? next = null)
        {
            this.next = next;
        }

        abstract protected string? getDescription();

        private string getDefaultDescription()
        {
            return "defaultDescription";
        }

        public string giveDescription()
        {
            string? result = this.getDescription();
            if (result != null)
                return result;
            if (next != null)
                return next.giveDescription();
            else
                return this.getDefaultDescription();
        }
    }
}
