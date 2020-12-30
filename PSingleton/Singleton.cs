using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Adapter.Interface.Duckling;
using Iterator.Iterators.Duckling;
using Iterator.Duckling;

namespace PSingleton.Duckling
{
    class Singleton
    {
        private static Singleton singleton;
        List<MenuItem> ducks;
        int n = 0;

        private Singleton()
        {
            ducks = new List<MenuItem>();
            addItem("Usual Duck", "It's just usual duck", 3.99);
            addItem("Hot-Duck", "Like a Hot-Dog, but the Hot-Duck", 3.99);
            addItem("Duck with pineapple", "From the makers of pineapple pizza", 3.99);
        }

        public void addItem(string name, string descr, double price)
        {
            MenuItem menuitem = new MenuItem(name, descr, price);
            ducks.Add(menuitem);
        }

        public static Singleton GetSingleton()
        {
            if (singleton == null)
            {
                singleton = new Singleton();
            }
            return singleton;
        }

        public IIterator<MenuItem> CreateIterator()
        {
            return new DuckMenuIterator(ducks);
        }

        public void DuckItem(IIterator<MenuItem> Iterator)
        {
            int i = 0;
            while (Iterator.hasNext())
            {
                Console.WriteLine("Element: ");
                MenuItem duck = Iterator.next();
                duck.getName();
                duck.getDescr();
                duck.getPrice();
                Console.WriteLine("{0} - {1} - {2}", duck.getName(), duck.getDescr(), duck.getPrice());
                i++;
            }
        }
    }
}
