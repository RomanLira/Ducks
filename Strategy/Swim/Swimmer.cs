using System;
using Strategy.Interface.Duckling;

namespace Strategy.Swim.Duckling
{
    class Swimmer : ISwim
    {
        public void Swim()
        {
            Console.WriteLine("I can swim! Am I Titanic?!");
        }
    }
}
