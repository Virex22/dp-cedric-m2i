using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Observer
{
    public class Vehicle : Subject
    {
        private int price = 0;
        private string description = "";

        public void setPrice(int price)
        {
            this.price = price;
            this.Notify();
        }

        public int getPrice()
        {
            return this.price;
        }

        public void setDescription(string description)
        {
            this.description = description;
            this.Notify();
        }

        public string getDescription()
        {
            return this.description;
        }
    }
}
