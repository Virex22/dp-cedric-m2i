using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.State
{
    public class ValidatedOrder : OrderState
    {
        public ValidatedOrder(Order order) : base(order)
        {
        }

        public override void AddProduct(Product product)
        {
            Console.WriteLine("Le produit " + product.getName() + " ne peut pas être ajouter, la commande est déjà valider");
        }

        public override void Clear()
        {
            this.order.Reset();
            Console.WriteLine("Annulation de la commande");
        }

        public override OrderState NextState()
        {
            return new DeliveredOrder(this.order);
        }

        public override void RemoveProduct(Product product)
        {
            Console.WriteLine("Le produit " + product.getName() + " ne peut pas être retirer, la commande est déjà valider, veuillez l'annuler");
        }
    }
}
