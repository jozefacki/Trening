using System;

namespace _3mTrening.Interfaces
{
    public interface IAddressInfo
    {
        string Street { get; set; }
        string Address { get; set; }
        string City { get; set; }
        string PostalCode { get; set; }
        string PhoneNumber { get; set; }
    }
    public interface ICard
    {
        string CardNumber { get; set; }
        string Name { get; set; }
        DateTime ValidTo { get; set; }
    }

    public interface CartItem
    {
        string ProductId { get; set; }
        int Quantity { get; set; }
        double Price { get; set; }
    }
}
