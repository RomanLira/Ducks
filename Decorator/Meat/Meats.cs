using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator.Meat.Duckling
{
    public abstract class Meats
    {
        protected string descr;

        public string GetDescr()
        {
            return descr;
        }

        public abstract double cost();

       /* private Meats meats;

        public Meats(string name, Meats meats)
        {
            this.meats = meats;
            Name = name;
        }

        public Meats(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public decimal Price()
        {
            return GetPrice() + (meats != null ? meats.Price() : 0);
        }
        
        protected abstract decimal GetPrice();*/
    }
}
