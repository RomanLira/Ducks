using System;
using Adapter.Interface.Duckling;

namespace Adapter.Duckling
{
    class WildDuck : IDuck
    {
        public void Fly()
        {
            Console.WriteLine("I can fly");
        }

        public void Quack()
        {
            Console.WriteLine("Quack-quack");
        }
    }
}
