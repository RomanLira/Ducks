using System;
using Strategy.Interface.Duckling;

namespace Strategy.Quack.Duckling
{
    class CanQuack : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("I make 'Quack-quack', yeah!");
        }
    }
}
