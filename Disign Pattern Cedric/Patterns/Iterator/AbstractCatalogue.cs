using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Iterator
{
    abstract public class AbstractCatalogue<TElement, TIterator> 
        where TElement : AbstractElement
        where TIterator : AbstractIterator<TElement>
    {
        protected List<TElement> elements;
           
        abstract public TIterator Search();
    }
}
