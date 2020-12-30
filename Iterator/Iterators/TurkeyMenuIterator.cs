using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Iterator.Duckling;

namespace Iterator.Iterators.Duckling
{
    class TurkeyMenuIterator : IIterator<MenuItem>
    {
        MenuItem[] items;
        int n;

        public TurkeyMenuIterator(MenuItem[] items)
        {
            this.items = items;
        }

        public MenuItem next()
        {
            n++;
            return items[n - 1];
        }

        public Boolean hasNext()
        {
            if (n >= items.Length || items[n] == null)
                return false;
            else
                return true;
        }
    }
}
