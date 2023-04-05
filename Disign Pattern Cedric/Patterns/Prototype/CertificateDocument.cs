using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Prototype
{
    public class CertificateDocument : AbstractDocument
    {
        public override void Draw()
        {
            Console.WriteLine(this.Print());
        }

        public override AbstractDocument Duplicate()
        {
            AbstractDocument document = new CertificateDocument();
            document.Fill(this.content);
            return document;
        }

        public override string Print()
        {
            return "<CERTIFICATE>" + this.content + "</CERTIFICATE>";
        }
    }
}
