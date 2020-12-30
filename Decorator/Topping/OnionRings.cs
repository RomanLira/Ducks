using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Decorator.Meat.Duckling;

namespace Decorator.Topping.Duckling
{
    class OnionRings : Toppings
    {
        Meats meats;

        public OnionRings(Meats meats)
        {
            this.meats = meats;
            descr = GetDescr();
        }

        public override string GetDescr()
        {
            return meats.GetDescr() + ", Onion Rings";
        }

        public override double cost()
        {
            return 1.99 + meats.cost();
        }


        /*public OnionRings(Meats m)
            : base(m.Name + ", + Onion Rings", m)
        {
        }

        protected override decimal GetPrice()
        {
            return 4;
        }*/
    }
}
