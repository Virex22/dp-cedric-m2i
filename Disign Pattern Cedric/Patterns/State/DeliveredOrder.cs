using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.State
{
    public class DeliveredOrder : OrderState
    {
        public DeliveredOrder(Order order) : base(order)
        {
        }

        public override void AddProduct(Product product)
        {
            Console.WriteLine("Impossible d'ajouter le produit " + product.getName() + ", Car la commande est déjà Livrée");
        }

        public override void Clear()
        {
            Console.WriteLine("Impossible d'annuler la commande, car la commande est déjà Livrée");
        }

        public override OrderState NextState()
        {
            Console.WriteLine("Impossible de passez à l'état suivant");
            return this;
        }

        public override void RemoveProduct(Product product)
        {
            Console.WriteLine("Impossible de retirer le produit " + product.getName() + ", Car la commande est déjà Livrée");
        }
    }
}
