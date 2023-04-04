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
        // le tester permet d'afficher les outputs des patterns
        TestingFluent tester = new TestingFluent();

        tester
        /*.testSingleton()
        .testAbstractFactory()
        .testAdapter()
        .testDecorator()
        .testIterator()
        .testObserver()
        .testBridge()
        .testState() 
        .testMemento()
        .testChainOfResponsibility()
        .testProxy()  
        .testFlyWeight()
        .testFacade()  */
        .testStrategy()
        .testTemplateMethod()
        ;
    } 
}
