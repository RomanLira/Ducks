using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator.Duckling
{
    public class MenuItem
    {
        string name;
        string descr;
        double price;

        public MenuItem(string name, string descr, double price)
        {
            this.name = name;
            this.descr = descr;
            this.price = price;
        }

        public string getName()
        {
            return name;
        }

        public string getDescr()
        {
            return descr;
        }

        public double getPrice()
        {
            return price;
        }
    }
}
