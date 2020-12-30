using System;
using Strategy.Interface.Duckling;

namespace Strategy.Fly.Duckling
{
    class CanFly : IFly
    {
        public void Fly()
        {
            Console.WriteLine("I can fly, yeah!");
        }
    }
}
