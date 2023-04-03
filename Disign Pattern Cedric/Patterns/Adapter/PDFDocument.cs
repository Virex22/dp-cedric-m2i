using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Adapter
{
    class PDFDocument : IDocument
    {
        private ComponentPDF ComponentPDF { get; set; }

        public PDFDocument(ComponentPDF componentPDF)
        {
            ComponentPDF = componentPDF;
        }

        public string Draw()
        {
            this.ComponentPDF.PrepareShowing();
            this.ComponentPDF.Refresh();
            return this.ComponentPDF.EndShowing();
        }

        public void Print()
        {
            this.ComponentPDF.PrepareShowing();
            this.ComponentPDF.SendToPrint();
        }

        public void SetContent(string content)
        {
            this.ComponentPDF.PdfSetContent(content);
        }
    }
}
