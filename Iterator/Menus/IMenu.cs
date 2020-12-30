using Iterator.Iterators.Duckling;
using Iterator.Duckling;

namespace Iterator.Menus.Duckling
{
    public interface IMenu
    {
        IIterator<MenuItem> CreateIterator();
    }
}
