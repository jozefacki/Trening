using System.Collections.Generic;

namespace _3mTrening.Interfaces
{
    public interface IShipmentService
    {
        void Ship(IAddressInfo info, IEnumerable<CartItem> items);
    }
}
