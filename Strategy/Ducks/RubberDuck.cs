using Strategy.Fly.Duckling;
using Strategy.Quack.Duckling;
using Strategy.Swim.Duckling;

namespace Strategy.Ducks.Duckling
{
    class RubberDuck : BaseDuck
    {
        public RubberDuck()
            : base(new CannotFly(), new Squeak(), new WoodSwim())
        { }
    }
}
