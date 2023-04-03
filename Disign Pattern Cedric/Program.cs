using Patterns.Singleton;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("test singleton");
        SingletonLiasse.getInstance().Add("doc1");
        SingletonLiasse.getInstance().Remove("doc1");
        Console.WriteLine("OK");
    }  
}
