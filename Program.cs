using System.Collections;
using Strategy.Ducks.Duckling;
using Adapter.Duckling;
using Adapter.Interface.Duckling;
using Iterator.Duckling;
using Iterator.Menus.Duckling;
using Iterator.Iterators.Duckling;
using Decorator.Meat.Duckling;
using Decorator.Topping.Duckling;
using PSingleton.Duckling;

namespace Duckling
{
    class Program
    {
        static void Main(string[] args)
        {
            #region(Strategy)
            BaseDuck mduck = new MallardDuck();
            System.Console.WriteLine("I'm Mallard Duck!");
            mduck.ShowInfo();
            System.Console.WriteLine();

            BaseDuck wduck = new WoodDuck();
            System.Console.WriteLine("I'm Wood Duck!");
            wduck.ShowInfo();
            System.Console.WriteLine();

            BaseDuck rduck = new RubberDuck();
            System.Console.WriteLine("I'm Rubber Duck!");
            rduck.ShowInfo();
            System.Console.WriteLine();

            BaseDuck uduck = new UnusualDuck();
            System.Console.WriteLine("I'm Unusual Duck!");
            uduck.ShowInfo();
            System.Console.WriteLine();
            #endregion

            #region(Adapter)
            WildDuck duck = new WildDuck();
            WildTurkey turkey = new WildTurkey();
            IDuck turkeyAdapter = new TurkeyAdapter(turkey);

            System.Console.WriteLine("The Turkey says:");
            turkey.Gobble();
            turkey.Fly();
            System.Console.WriteLine();

            System.Console.WriteLine("The Duck says:");
            TestDuck(duck);
            System.Console.WriteLine();

            System.Console.WriteLine("The TurkeyAdapter says:");
            TestDuck(turkeyAdapter);
            System.Console.WriteLine();
            #endregion

            #region(Iterator)
            var duckMenu = new DuckMenu();
            var turkeyMenu = new TurkeyMenu();
            var printMenu = new PrintMenu(duckMenu, turkeyMenu);
            printMenu.Print();
            #endregion

            #region(Decorator)
            System.Console.WriteLine();
            Meats bbqduck = new BBQDuck();
            System.Console.WriteLine("Position: {0} ${1}", bbqduck.GetDescr(), bbqduck.cost());
            bbqduck = new ExxxtraChili(bbqduck);
            bbqduck = new OnionRings(bbqduck);
            System.Console.WriteLine("Position: {0} ${1}", bbqduck.GetDescr(), bbqduck.cost());
            Meats bbqturk = new BBQTurkey();
            bbqturk = new ExxxtraChili(bbqturk);
            System.Console.WriteLine("Position: {0} ${1}", bbqturk.GetDescr(), bbqturk.cost());
            #endregion

            #region(Singleton)
            System.Console.WriteLine();
            Singleton singleton = Singleton.GetSingleton();

            IIterator<MenuItem> iterator = singleton.CreateIterator();
            singleton.DuckItem(iterator);
            #endregion
        }

        static void TestDuck(IDuck duck)
        {
            duck.Quack();
            duck.Fly();
        }
    }
}
