using System;
using Adapter.Interface.Duckling;

namespace Adapter.Duckling
{
    class WildTurkey : ITurkey
    {
        public void Gobble()
        {
            Console.WriteLine("Gobble-gobble");
        }

        public void Fly()
        {
            Console.WriteLine("I can fly only a short distance");
        }
    }
}
