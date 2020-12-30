using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator.Meat.Duckling
{
    class BBQTurkey : Meats
    {
        public BBQTurkey()
        {
            descr = "BBQ Turkey";
        }

        public override double cost()
        {
            return 3.99;
        }
    }
}
