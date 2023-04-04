using Patterns.Flyweight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestHandler;

namespace TestHandler
{
    public class TestFlyweight : AbstractTestHandler
    {
        public TestFlyweight()
        {
            this.patternName = "FlyWeight";
        }

        protected override void testPattern()
        {
            FactoryOption factory = new FactoryOption();
            Console.WriteLine("Créer car1 à 5000euros");
            CarOrdered car = new CarOrdered(5000);
            Console.WriteLine("créer car2 à 5000euros");
            CarOrdered car2 = new CarOrdered(5000);
            Console.WriteLine("ajoute climatisation et pneu de course sur car1");
            car.AddOption("climatisation", 150, factory);
            car.AddOption("Pneu de course", 300, factory); 
            Console.WriteLine("affichage options car1");
            car.ShowOption();

            Console.WriteLine("ajoute climatisation sur car2");
            car2.AddOption("climatisation", 150, factory);
            Console.WriteLine("affichage options car2");
            car2.ShowOption();
        }
    }
}
