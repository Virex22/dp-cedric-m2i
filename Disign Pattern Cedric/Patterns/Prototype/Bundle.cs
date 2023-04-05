using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Prototype
{
    public class Bundle
    {
        protected List<AbstractDocument> documents = new List<AbstractDocument>();

        public List<AbstractDocument> GetDocuments()
        {
            return documents;
        }
        public void SetDocuments(List<AbstractDocument> documents)
        {
            this.documents = documents;
        }
    }
}
