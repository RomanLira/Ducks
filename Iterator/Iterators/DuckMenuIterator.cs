using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Iterator.Duckling;

namespace Iterator.Iterators.Duckling
{
    class DuckMenuIterator : IIterator<MenuItem>
    {
        int n = 0;
        List<MenuItem> items;

        public DuckMenuIterator(List<MenuItem> items)
        {
            this.items = items;
        }

        public MenuItem next()
        {
            n++;
            return (items[n - 1]);
        }

        public bool hasNext()
        {
            if (n >= items.Count || items[n] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
