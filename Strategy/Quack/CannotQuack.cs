using System;
using Strategy.Interface.Duckling;

namespace Strategy.Quack.Duckling
{
    class CannotQuack : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("'Quack-quack'? Not today...");
        }
    }
}
