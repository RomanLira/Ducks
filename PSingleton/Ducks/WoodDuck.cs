using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSingleton.Ducks.Duckling
{
    class WoodDuck : IBaseDuck
    {
        public void Fly()
        {
            Console.WriteLine("I cannot fly");
        }

        public void Quack()
        {
            Console.WriteLine("Knock-knock!");
        }

        public void Swim()
        {
            Console.WriteLine("I cannot swim");
        }
    }
}
