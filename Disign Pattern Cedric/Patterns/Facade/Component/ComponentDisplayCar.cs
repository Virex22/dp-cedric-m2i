using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Facade.Component
{
    public class ComponentDisplayCar
    {
        public string display(string name, float price)
        {
            return name + " " + price + " euros";
        }
        public string displayHTML(string name, float price)
        {
            return "<HTML> " + this.display(name,price) + " </HTML>";
        }
        public string displayXML(string name, float price)
        {
            return "<XML> " + this.display(name, price) + " </XML>";
        }
        public string displayApple(string name, float price)
        {
            return "<APPLE> " + this.display(name, price) + " </APPLE>";
        }
        public string displayEverythingElse(string name, float price)
        {
            return "<EVERYTHINGELSE> " + this.display(name, price) + " </EVERYTHINGELSE>";
        }
    }
}
