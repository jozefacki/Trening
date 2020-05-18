namespace _3mTrening.Interfaces
{
    interface ICartService
    {
        double Total();
        IEnumerable<CartItem> Items();
    }
}
