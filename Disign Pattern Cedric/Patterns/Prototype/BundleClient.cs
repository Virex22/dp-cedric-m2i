using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Prototype
{
    public class BundleClient : Bundle
    {
        public void Create(BundleBlank bundleBlank ,string firstname, string lastname, int age)
        {
            foreach(AbstractDocument document in bundleBlank.GetDocuments())
            {
                AbstractDocument newDocument = document.Duplicate();
                newDocument.Fill("Prenom : " + firstname + "; Nom de famille " + lastname.ToUpper() + ";age :" + age);
                this.documents.Add(newDocument);
            }   
        }
        public void Draw()
        {
            foreach (AbstractDocument document in this.documents)
                document.Draw();
        }
        public string Print()
        {
            string output = "";
            foreach (AbstractDocument document in this.documents)
                output += document.Print();
            return output;
        }
    }
}
