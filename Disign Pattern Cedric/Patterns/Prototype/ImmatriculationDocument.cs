using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Prototype
{
    public class ImmatriculationDocument : AbstractDocument
    {
        public override void Draw()
        {
            Console.WriteLine(this.Print());
        }

        public override AbstractDocument Duplicate()
        {
            AbstractDocument document = new ImmatriculationDocument();
            document.Fill(this.content);
            return document;
        }

        public override string Print()
        {
            return "<IMMATRICULATION>" + this.content + "</IMMATRICULATION>";
        }
    }
}
