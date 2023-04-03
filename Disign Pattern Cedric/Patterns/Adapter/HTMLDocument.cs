using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Adapter
{
    class HTMLDocument : IDocument
    {
        private string content;

        public HTMLDocument()
        {
            this.content = "";
        }

        protected string getContent()
        {
            return content;
        }

        public void SetContent(string content)
        {
            this.content = content;
        }

        public string Draw()
        {
            return getHTML();
        }

        public void Print()
        {
            Console.WriteLine(this.getHTML());
        }

        // to differency html and pdf format
        private string getHTML()
        {
            return "<html>" + this.getContent() + "</html>";
        }
    }
}
