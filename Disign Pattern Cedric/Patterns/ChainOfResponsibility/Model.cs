using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.ChainOfResponsibility
{
    public class Model : BasicObject
    {
        private string? model;
        public Model(string? model, BasicObject? next = null) : base(next)
        {
            this.model = model;
        }

        protected override string? getDescription()
        {
            if (this.model == null)
                return null;
            return "Model : " + this.model;
        }
    }
}
