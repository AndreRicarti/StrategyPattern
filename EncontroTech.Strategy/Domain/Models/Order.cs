using EncontroTech.Strategy.Dados.Domain.Strategies.Payments.Interfaces;

namespace EncontroTech.Strategy.Dados.Domain.Models;

// Contexto - É a classe que vai utilizar a estratégia
public sealed class Order(
    decimal price, 
    IPaymentStrategy paymentStrategy)
{
    private IPaymentStrategy PaymentStrategy { get; } = paymentStrategy;

    private decimal Price { get; } = price;

    // Esse método recebe a estratégia de pagamento
    public void ProcessOrder()
    {
        PaymentStrategy.PayAsync(Price);
    }
}