using System;
using Strategy.Interface.Duckling;

namespace Strategy.Swim.Duckling
{
    class WoodSwim : ISwim
    {
        public void Swim()
        {
            Console.WriteLine("I cannot swim. But I'm not drowning");
        }
    }
}
