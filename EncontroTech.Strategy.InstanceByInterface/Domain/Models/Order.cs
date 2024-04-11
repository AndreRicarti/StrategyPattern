using EncontroTech.Strategy.InstanceByInterface.Domain.Strategies.Payments.Interfaces;

namespace EncontroTech.Strategy.InstanceByInterface.Domain.Models;

public sealed class Order(
    decimal price,
    IPaymentStrategy paymentStrategy) : IPayment
{
    private decimal Price { get; } = price;

    private IPaymentStrategy PaymentStrategy { get; } = paymentStrategy;

    // E na hora de chamar a estratégia, ela se passa como uma instância para nossa estratégia
    public void ProcessOrder()
    {
        PaymentStrategy.PayAsync(this);
    }

    public decimal GetValue()
    {
        return Price;
    }
}