using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Adapter.Interface.Duckling;

namespace Duckling
{
    class TurkeyAdapter : IDuck
    {
        ITurkey turkey;

        public TurkeyAdapter(ITurkey turkey)
        {
            this.turkey = turkey;
        }

        public void Quack()
        {
            turkey.Gobble();
        }

        public void Fly()
        {
            turkey.Fly();
            turkey.Fly();
        }
    }
}
