using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.State
{
    public class PendingOrder : OrderState
    {
        public PendingOrder(Order order) : base(order)
        {
        }

        public override void AddProduct(Product product)
        {
            this.order.GetProductsList().Add(product);
            Console.WriteLine("Ajout du produit " + product.getName() + " dans la commande");
        }

        public override void Clear()
        {
            this.order.Reset();
            Console.WriteLine("Annulation de la commande");
        }

        public override OrderState NextState()
        {
            return new ValidatedOrder(this.order);
        }

        public override void RemoveProduct(Product product)
        {
            this.order.GetProductsList().Remove(product);
            Console.WriteLine("Le produit " + product.getName() + " à été retirer de la commande");
        }
    }
}
