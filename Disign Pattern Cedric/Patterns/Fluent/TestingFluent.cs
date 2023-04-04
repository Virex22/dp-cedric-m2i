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
    }
}
