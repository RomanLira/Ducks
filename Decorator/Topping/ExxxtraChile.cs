using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Decorator.Meat.Duckling;

namespace Decorator.Topping.Duckling
{
    class ExxxtraChili : Toppings
    {
        Meats meats;

        public ExxxtraChili(Meats meats)
        {
            this.meats = meats;
            descr = GetDescr();
        }

        public override string GetDescr()
        {
            return meats.GetDescr() + ", Exxxtra Chili Sauce";
        }

        public override double cost()
        {
            return 0.99 + meats.cost();
        }
    }
}
