using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Iterator
{
    abstract public class AbstractIterator<TElement>
        where TElement : AbstractElement
    {
        protected int position = 0;
        protected TElement element;
        
        public int Begin()
        {
            return 0;
        }
        
        public void Next()
        {
            this.position++;
        }

        abstract public bool End();

        abstract public TElement Item();
    }
}
