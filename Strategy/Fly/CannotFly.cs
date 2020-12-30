using System;
using Strategy.Interface.Duckling;

namespace Strategy.Fly.Duckling
{
    class CannotFly : IFly
    {
        public void Fly()
        {
            Console.WriteLine("I cannot fly, I'm quacking loser :(");
        }
    }
}
