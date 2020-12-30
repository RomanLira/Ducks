using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Strategy.Interface.Duckling;

namespace Strategy.Quack.Duckling
{
    class UnusualQuack : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("If you want to talk, just phone me: 8-800-555-35-35");
        }
    }
}
