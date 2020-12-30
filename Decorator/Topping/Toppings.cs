using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Decorator.Meat.Duckling;

namespace Decorator.Topping.Duckling
{
    public abstract class Toppings : Meats
    {
        public abstract new string GetDescr();


    /*
        protected Toppings(string n, Meats meats)
            : base(n, meats)
        {
        }

        protected override decimal GetPrice();*/
    }
}
