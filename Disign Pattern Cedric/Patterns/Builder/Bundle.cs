using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Builder
{

    abstract public class Bundle
    {
        protected List<string> documents = new List<string>();

        abstract public void AddDocument(string document);
        public string PrintDocument()
        {
            string output = "";
            foreach (string document in documents)
            {
                output += "   " + document + "\n";
            }
            return output;
        }
    }
}
