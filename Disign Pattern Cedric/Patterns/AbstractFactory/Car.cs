using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory
{
    abstract public class Car
    {
        public string name { get; set; }
        private int wheelCount = 4;

        public Car(string name)
        {
            this.name = name;
        }

        public void Drive()
        {
            Console.WriteLine("Driving a car");
        }

        abstract public void FillUp();
    }
}
