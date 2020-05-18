using System.Collections.Generic;

namespace _3mTrening.Interfaces
{
    public interface ICartService
    {
        double Total();
        IEnumerable<CartItem> Items();
    }
}
