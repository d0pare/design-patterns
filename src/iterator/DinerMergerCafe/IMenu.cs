using System.Collections.Generic;

namespace DinerMergerCafe
{
    public interface IMenu
    {
        IEnumerator<MenuItem> CreateIterator();
    }
}