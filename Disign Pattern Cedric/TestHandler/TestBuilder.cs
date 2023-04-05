using Patterns.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHandler
{
    public class TestBuilder : AbstractTestHandler
    {
        public TestBuilder()
        {
            this.patternName = "Builder";
        }

        protected override void testPattern()
        {
            SellerDirector director = new SellerDirector();
            Bundle pdfBundle = director.ConstructBundlePDF();
            Bundle htmlBundle = director.ConstructBundleHTML();
            Console.WriteLine("pdfBundle :");
            Console.WriteLine(pdfBundle.PrintDocument());
            Console.WriteLine("htmlBundle :");
            Console.WriteLine(htmlBundle.PrintDocument());
        }
    }
}
