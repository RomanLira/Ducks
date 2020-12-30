using System.Collections.Generic;
using Iterator.Duckling;
using Iterator.Iterators.Duckling;

namespace Iterator.Menus.Duckling
{
    public class DuckMenu : IMenu
    {
        List<MenuItem> menuItems;

        public DuckMenu()
        {
            menuItems = new List<MenuItem>();
            addItem("Usual Duck", "It's just usual duck", 3.99);
            addItem("Hot-Duck", "Like a Hot-Dog, but the Hot-Duck", 3.99);
            addItem("Duck with pineapple","From the makers of pineapple pizza", 3.99);
        }

        public void addItem(string name, string descr, double price)
        {
            MenuItem menuitem = new MenuItem(name, descr, price);
            menuItems.Add(menuitem);
        }

        public IIterator<MenuItem> CreateIterator()
        {
            return new DuckMenuIterator(menuItems);
        }
    }
}
