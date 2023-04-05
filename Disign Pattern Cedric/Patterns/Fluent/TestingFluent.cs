using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestHandler;

namespace Patterns.Fluent
{
    public class TestingFluent
    {
        public TestingFluent testSingleton()
        {
            new TestSingleton().Handle();
            return this;
        }
        public TestingFluent testAbstractFactory()
        {
            new TestAbstractFactory().Handle();
            return this;
        }
        public TestingFluent testAdapter()
        {
            new TestAdapter().Handle();
            return this;
        }
        public TestingFluent testBridge()
        {
            new TestBridge().Handle();
            return this;
        }
        public TestingFluent testDecorator()
        {
            new TestDecorator().Handle();
            return this;
        }
        public TestingFluent testIterator()
        {
            new TestIterator().Handle();
            return this;
        }
        public TestingFluent testObserver()
        {
            new TestObserver().Handle();
            return this;
        }
        public TestingFluent testState()
        {
            new TestState().Handle();
            return this;
        }
        public TestingFluent testMemento()
        {
            new TestMemento().Handle();
            return this;
        }
        public TestingFluent testChainOfResponsibility()
        {
            new TestChainOfResponsability().Handle();
            return this;
        }
        public TestingFluent testProxy()
        {
            new TestProxy().Handle();
            return this;
        }
        public TestingFluent testFlyWeight()
        {
            new TestFlyweight().Handle();
            return this;
        }
        public TestingFluent testFacade()
        {
            new TestFacade().Handle();
            return this;
        }
        public TestingFluent testStrategy()
        {
            new TestStrategy().Handle();
            return this;
        }
        public TestingFluent testTemplateMethod()
        {
            new TestTemplateMethod().Handle();
            return this;
        }
        public TestingFluent testComposite()
        {
            new TestComposite().Handle();
            return this;
        }
        public TestingFluent testPrototype()
        {
            new TestPrototype().Handle();
            return this;
        }
        public TestingFluent testCommand()
        {
            new TestCommand().Handle();
            return this;
        }
        public TestingFluent testBuilder()
        {
            new TestBuilder().Handle();
            return this;
        }
    }
}
