using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.State
{
    abstract public class OrderState
    {
        protected Order order;

        public OrderState(Order order)
        {
            this.order = order;
        }

        abstract public void AddProduct(Product product);
        abstract public void RemoveProduct(Product product);
        abstract public void Clear();
        abstract public OrderState NextState();
    }
}
