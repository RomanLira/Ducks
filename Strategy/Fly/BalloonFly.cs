using System;
using Strategy.Interface.Duckling;

namespace Strategy.Fly.Duckling
{
    class BalloonFly : IFly
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying on the air ballon, ha-ha-ha!");
        }
    }
}
