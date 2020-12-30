using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSingleton.Ducks.Duckling
{
    class RubberDuck : IBaseDuck
    {
        public void Fly()
        {
            Console.WriteLine("I cannot fly");
        }

        public void Quack()
        {
            Console.WriteLine("Peep-peeep");
        }

        public void Swim()
        {
            Console.WriteLine("I can swim))");
        }
    }
}
