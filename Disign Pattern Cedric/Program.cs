using Patterns.Iterator;
using Patterns.Adapter;
using Patterns.Singleton;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("test singleton");
        SingletonLiasse.getInstance().Add("doc1");
        SingletonLiasse.getInstance().Remove("doc1");
        
        Console.WriteLine("test adapteur");
        IDocument html = new HTMLDocument();
        IDocument pdf = new PDFDocument(new ComponentPDF());
        ShowAndPrintIDocument(html, "test adapteur");
        ShowAndPrintIDocument(pdf, "test adapteur");

        Console.WriteLine("test iterateur");
        VehicleCatalogue catalogue = new VehicleCatalogue();
        VehicleIterator iterator = catalogue.Search();
        catalogue.setVehicleList(getVehicleList());
        while (!iterator.End())
        {
            Console.WriteLine(iterator.Item().GetInfo());
            iterator.Next();
        }
        
    }
    
    static private void ShowAndPrintIDocument(IDocument document,string text)
    {
        document.SetContent(text);
        Console.WriteLine("Ecriture de : " + document.Draw());
        Console.WriteLine("Impression en cours : ");
        document.Print();
    }
    
    static private List<Vehicle> getVehicleList()
    {
        return new List<Vehicle>()
        {
           new Vehicle("tesla model X"),
           new Vehicle("Peugot 208"),
           new Vehicle("Citroen C3"),
           new Vehicle("Volkswagen Polo")
        };
    }
}
