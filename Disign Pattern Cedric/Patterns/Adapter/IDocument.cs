using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Adapter
{
    interface IDocument
    {
        public void SetContent(string content);
        public string Draw();
        public void Print();
    }
}
