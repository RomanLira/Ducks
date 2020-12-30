using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator.Iterators.Duckling
{
    public interface IIterator<out T>
    {
        Boolean hasNext();
        T next();
    }
}
