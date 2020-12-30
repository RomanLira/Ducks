using System;
using Strategy.Interface.Duckling;

namespace Strategy.Swim.Duckling
{
    class Walker : ISwim
    {
        public void Swim()
        {
            Console.WriteLine("I cannot swim, but I can WALK, motherquacker!");
        }
    }
}
