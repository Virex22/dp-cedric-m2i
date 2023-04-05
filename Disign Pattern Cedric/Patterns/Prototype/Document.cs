using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Prototype
{
    abstract public class AbstractDocument
    {
        protected string content = "";

        abstract public AbstractDocument Duplicate();
        abstract public string Print();
        abstract public void Draw();

        public void Fill(string content)
        {
            this.content = content;
        }
    }
}
