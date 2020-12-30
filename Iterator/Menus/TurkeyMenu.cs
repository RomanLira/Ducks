using System;
using Iterator.Iterators.Duckling;
using Iterator.Duckling;

namespace Iterator.Menus.Duckling
{
    public class TurkeyMenu : IMenu
    {
        int max = 6;
        int n = 0;
        MenuItem[] menuItems;

        public TurkeyMenu()
        {
            menuItems = new MenuItem[max];
            addItem("Usual Turkey", "It's just usual Turkey", 2.99);
            addItem("Turkey's like a Duck", "Duck? No, it's TURKEY", 2.99);
            addItem("Turkish Turkey", "La-la-la-la-la-la-la, Natashhhhhha", 2.99);
        }

        public void addItem(string name, string descr, double price)
        {
            MenuItem menuitem = new MenuItem(name, descr, price);
            try
            {
                menuItems[n] = menuitem;
                n++;
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                throw new ArgumentOutOfRangeException("Index is out of range.", ex);
            }
        }
        
        public IIterator<MenuItem> CreateIterator()
        {
            return new TurkeyMenuIterator(menuItems);
        }
    }
}
