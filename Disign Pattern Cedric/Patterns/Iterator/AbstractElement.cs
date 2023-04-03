using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Iterator
{
    abstract public class AbstractElement
    {
        protected string name;

        public AbstractElement(string name = "")
        {
            this.name = name;
        }

        abstract public string GetInfo();
    }
}
