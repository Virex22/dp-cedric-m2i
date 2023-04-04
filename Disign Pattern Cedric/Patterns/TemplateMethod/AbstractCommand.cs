using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.TemplateMethod
{
    abstract public class AbstractCommand
    {
        protected float CostTTC;
        protected float CostHT;
        protected float CostTVA;

        protected AbstractCommand(float costHT)
        {
            CostHT = costHT;
        }

        public void Draw()
        {
            Console.WriteLine("CostTTC : " + this.CostTTC);
            Console.WriteLine("CostHT : " + this.CostHT);
            Console.WriteLine("CostTVA : " + this.CostTVA);
        }

        public void calcTTC()
        {
            this.calcTVA();
            this.CostTTC = this.CostHT + this.CostTVA;
        }

        abstract protected void calcTVA();
    }
}
