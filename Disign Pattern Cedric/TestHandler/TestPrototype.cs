using Patterns.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHandler
{
    public class TestPrototype : AbstractTestHandler
    {
        public TestPrototype()
        {
            this.patternName = "Prototype";
        }

        protected override void testPattern()
        {
            Console.WriteLine("creation de la liasse vide");
            BundleBlank bundle = new BundleBlank();
            bundle.Add(new CertificateDocument());
            bundle.Add(new ImmatriculationDocument());
            bundle.Add(new PurchaseOrderDocument());

            Console.WriteLine("creation de la liasse client en dupliquant la liasse vide");
            BundleClient bundleClient = new BundleClient();
            bundleClient.Create(bundle, "vincent", "remy", 21);
            bundleClient.Draw();
        }
    }
}
