using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator.Meat.Duckling
{
    class BBQDuck : Meats
    {
        public BBQDuck()
        {
            descr = "BBQ Duck";
        }

        public override double cost()
        {
            return 4.99;
        }
    }
}
