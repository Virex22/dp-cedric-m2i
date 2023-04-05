using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Prototype
{
    public class BundleBlank : Bundle
    {
        public void Add(AbstractDocument document)
        {
            this.documents.Add(document);
        }
        public void Remove(AbstractDocument document)
        {
            this.documents.Remove(document);
        }
    }
}
