using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.State
{
    public class Order
    {
        protected List<Product> products;
        protected OrderState state;

        public Order()
        {
            this.state = new PendingOrder(this);
            this.products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            this.state.AddProduct(product);
        }
        public void RemoveProduct(Product product)
        {
           this.state.AddProduct(product); 
        }
        public void Clear()
        {
            this.state.Clear();
        }
        public void NextState()
        {
            this.state = this.state.NextState();
        }
        public string GetProducts()
        {
            string recap = "";
            foreach (Product product in this.products)
                recap += "   " + product.getName() + " " + product.getPrice() + "\r\n";
            return recap;
        }
        public List<Product> GetProductsList()
        {
            return products;
        }
        public void Reset()
        {
            this.state = new PendingOrder(this);
            this.products = new List<Product>();
        }
    }
}
