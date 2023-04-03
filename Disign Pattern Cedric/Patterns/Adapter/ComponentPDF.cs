using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Adapter
{
    class ComponentPDF
    {
        private string content;
        private string outputContent;

        public ComponentPDF()
        {
            this.content = "";
        }

        public void PdfSetContent(string content)
        {
            this.content = content;
        }

        // to differency html and pdf format
        public void PrepareShowing()
        {
            this.outputContent = "<pdf>" + this.content + "</pdf>";
        }

        public void Refresh()
        {
            Console.WriteLine("refreshing ...");
        }

        public string EndShowing()
        {
            return this.outputContent;
        }

        public void SendToPrint()
        {
            Console.WriteLine(this.outputContent);
        }
    }
}
