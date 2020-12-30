using System;
using Strategy.Interface.Duckling;

namespace Strategy.Quack.Duckling
{
    class Squeak : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("I make 'Peep-peep-peep!'");
        }
    }
}
