using Patterns.ChainOfResponsibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.ChainOfResponsibility
{
    public class Mark : BasicObject
    {
        private string? mark;
        public Mark(string? mark, BasicObject? next = null) : base( next)
        {
            this.mark = mark;
        }

        protected override string? getDescription()
        {
            if (this.mark == null)
                return null;
            return "Marques : " + this.mark;
        }
    }
}
