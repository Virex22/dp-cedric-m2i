using Patterns.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHandler
{
    public class TestState : AbstractTestHandler
    {
        public TestState()
        {
            this.patternName = "State";
        }

        protected override void testPattern()
        {
            Console.WriteLine("Creation de la commande et on ajoute 2 produits");
            Order order = new Order();
            order.AddProduct(new Product("Toilette", 550));
            order.AddProduct(new Product("Douche", 1250));
            Console.WriteLine(order.GetProducts());

            Console.WriteLine("On valide la commande");
            order.NextState();

            Console.WriteLine("On essaie d'ajouter un produit");
            order.AddProduct(new Product("Lavabo", 250));
            Console.WriteLine("On l'annule");
            order.Clear();
            Console.WriteLine(order.GetProducts());

            Console.WriteLine("on ajoute les 3 produits");
            order.AddProduct(new Product("Toilette", 550));
            order.AddProduct(new Product("Douche", 1250));
            order.AddProduct(new Product("Lavabo", 250));
            Console.WriteLine(order.GetProducts());

            Console.WriteLine("On valide la commande et on se la fait livrée");
            order.NextState();
            order.NextState();

            Console.WriteLine("On essais de l'annuler");
            order.Clear();
            Console.WriteLine(order.GetProducts());
        }
    }
}
                                                                    