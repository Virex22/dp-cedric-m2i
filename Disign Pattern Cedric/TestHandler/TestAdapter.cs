using Patterns.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestHandler;

namespace TestHandler
{
    public class TestAdapter : AbstractTestHandler
    {
        public TestAdapter()
        {
            this.patternName = "Adapter";
        }

        protected override void testPattern()
        {
            IDocument html = new HTMLDocument();
            IDocument pdf = new PDFDocument(new ComponentPDF());
            ShowAndPrintIDocument(html, "test adapteur");
            ShowAndPrintIDocument(pdf, "test adapteur");
        }

        static private void ShowAndPrintIDocument(IDocument document, string text)
        {
            document.SetContent(text);
            Console.WriteLine("Ecriture de : " + document.Draw());
            Console.WriteLine("Impression en cours : ");
            document.Print();
        }
    }
}
