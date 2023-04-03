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
        Console.WriteLine("OK");
        Console.WriteLine("test adapteur");
        IDocument html = new HTMLDocument();
        IDocument pdf = new PDFDocument(new ComponentPDF());
        ShowAndPrintIDocument(html, "test adapteur");
        ShowAndPrintIDocument(pdf, "test adapteur");

    }
    
    static private void ShowAndPrintIDocument(IDocument document,string text)
    {
        document.SetContent(text);
        Console.WriteLine("Ecriture de : " + document.Draw());
        Console.WriteLine("Impression en cours : ");
        document.Print();
    }
}
