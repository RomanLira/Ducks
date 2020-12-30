using Strategy.Interface.Duckling;
namespace Strategy.Ducks.Duckling
{
    public abstract class BaseDuck
    {
        public IFly dfly;
        public IQuack dquack;
        public ISwim dswim;

        protected BaseDuck() { }

        protected BaseDuck(IFly fly, IQuack quack, ISwim swim)
        {
            this.dfly = fly;
            this.dquack = quack;
            this.dswim = swim;
        }

        public virtual void Fly()
        {
            dfly.Fly();
        }

        public virtual void Quack()
        {
            dquack.Quack();
        }

        public virtual void Swim()
        {
            dswim.Swim();
        }

        public void ShowInfo()
        {
            dfly.Fly();
            dquack.Quack();
            dswim.Swim();
        }
    }
}
