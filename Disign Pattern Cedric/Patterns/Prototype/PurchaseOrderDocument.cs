using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Prototype
{
    public class PurchaseOrderDocument : AbstractDocument
    {
        public override void Draw()
        {
            Console.WriteLine(this.Print());
        }

        public override AbstractDocument Duplicate()
        {
            AbstractDocument document = new PurchaseOrderDocument();
            document.Fill(this.content);
            return document;
        }

        public override string Print()
        {
            return "<PURCHASEORDER>" + this.content + "</PURCHASEORDER>";
        }
    }
}
