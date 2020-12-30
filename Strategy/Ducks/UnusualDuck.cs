using Strategy.Fly.Duckling;
using Strategy.Quack.Duckling;
using Strategy.Swim.Duckling;

namespace Strategy.Ducks.Duckling
{
    class UnusualDuck : BaseDuck
    {
        public UnusualDuck()
            : base(new BalloonFly(), new UnusualQuack(), new Walker())
        { }
    }
}
