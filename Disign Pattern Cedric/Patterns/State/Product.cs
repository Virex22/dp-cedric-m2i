using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.State
{
    public class Product
    {
        private string name;
        private float price;

        public Product(string name, float price)
        {
            this.name = name;
            this.price = price;
        }

        public string getName()
        {
            return this.name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public float getPrice()
        {
            return this.price;
        }
        public void setPrice(float price) {
            this.price = price;
        }
    }
}
