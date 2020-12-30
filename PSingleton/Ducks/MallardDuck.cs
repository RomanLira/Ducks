using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSingleton.Ducks.Duckling
{
    class MallardDuck : IBaseDuck
    {
        public void Fly()
        {
            Console.WriteLine("I believe I can fly");
        }

        public void Quack()
        {
            Console.WriteLine("Quack-quack!");
        }

        public void Swim()
        {
            Console.WriteLine("I can swim");
        }
    }
}
