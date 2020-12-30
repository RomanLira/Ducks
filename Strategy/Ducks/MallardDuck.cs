using Strategy.Fly.Duckling;
using Strategy.Quack.Duckling;
using Strategy.Swim.Duckling;

namespace Strategy.Ducks.Duckling
{
    class MallardDuck : BaseDuck
    {
        public MallardDuck()
            : base(new CanFly(), new CanQuack(), new Swimmer())
        { }
    }
}
