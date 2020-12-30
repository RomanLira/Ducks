using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Iterator.Iterators.Duckling;
using Iterator.Duckling;

namespace Iterator.Menus.Duckling
{
    class PrintMenu
    {
        IMenu DuckMenu;
        IMenu TurkeyMenu;

        public PrintMenu(IMenu DuckMenu, IMenu TurkeyMenu)
        {
            this.DuckMenu = DuckMenu;
            this.TurkeyMenu = TurkeyMenu;
        }

        public void Print()
        {
            var ducksIterator = DuckMenu.CreateIterator();
            var turkeysIterator = TurkeyMenu.CreateIterator();
            Console.WriteLine("Duck Menu: ");
            Print(ducksIterator);
            Console.WriteLine();
            Console.WriteLine("Turkey Menu: ");
            Print(turkeysIterator);
        }

        static void Print(IIterator<MenuItem> iterator)
        {
            while (iterator.hasNext())
            {
                var menuItem = iterator.next();
                Console.WriteLine("-------------");
                Console.Write(menuItem.getName() + " - Cost: ");
                Console.WriteLine(menuItem.getPrice() + "$");
                Console.WriteLine(menuItem.getDescr());
            }
        }
    }
}
