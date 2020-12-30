using Strategy.Fly.Duckling;
using Strategy.Quack.Duckling;
using Strategy.Swim.Duckling;

namespace Strategy.Ducks.Duckling
{
    class WoodDuck : BaseDuck
    {
        public WoodDuck()
            : base(new CannotFly(), new CannotQuack(), new WoodSwim())
        { }
    }
}
