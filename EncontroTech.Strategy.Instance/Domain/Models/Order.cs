using EncontroTech.Strategy.Instance.Domain.Strategies.Payments.Interfaces;

namespace EncontroTech.Strategy.Instance.Domain.Models;

public sealed class Order(
    decimal price,
    IPaymentStrategy paymentStrategy)
{
    //public int Id { get; }
    //public int ClientId { get; }

    public decimal Price { get; } = price;

    private IPaymentStrategy PaymentStrategy { get; } = paymentStrategy;

    public void ProcessOrder()
    {
        PaymentStrategy.PayAsync(this);
    }
}