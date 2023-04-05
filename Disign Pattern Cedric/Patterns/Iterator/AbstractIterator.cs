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
        protected AbstractCatalogue<TElement,AbstractIterator<TElement>> catalogue;

        protected AbstractIterator(AbstractCatalogue<TElement, AbstractIterator<TElement>> catalogue)
        {
            this.catalogue = catalogue;
        }

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
