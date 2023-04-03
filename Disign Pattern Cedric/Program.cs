using Patterns.Iterator;
using Patterns.Adapter;
using Patterns.Singleton;
using Patterns.AbstractFactory;
using Patterns.Decorator;
using Patterns.Fluent;

class Program
{
    static void Main(string[] args)
    {
        TestingFluent tester = new TestingFluent();
        tester
            .testSingleton()
            .testAbstractFactory()
            .testAdapter()
            .testDecorator()
            .testIterator()
            .testObserver()

            .testBridge()
        ;
    } 
}
