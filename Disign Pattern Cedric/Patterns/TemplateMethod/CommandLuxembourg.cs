using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.TemplateMethod
{
    public class CommandLuxembourg : AbstractCommand
    {
        public CommandLuxembourg(float costHT) : base(costHT)
        {
        }

        protected override void calcTVA()
        {
            this.CostTVA = (this.CostHT * 0.12f) + (this.CostHT * 0.15f);
        }
    }
}
