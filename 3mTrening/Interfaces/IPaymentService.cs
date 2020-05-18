namespace _3mTrening.Interfaces
{
    public interface IPaymentService
    {
        bool Charge(double total, ICard card);
    }
}
