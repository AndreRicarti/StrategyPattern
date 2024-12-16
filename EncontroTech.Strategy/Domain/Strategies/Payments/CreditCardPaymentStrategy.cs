using EncontroTech.Strategy.Dados.Domain.Strategies.Payments.Interfaces;

namespace EncontroTech.Strategy.Dados.Domain.Strategies.Payments;

// Estratégia - Concretas
public sealed class CreditCardPaymentStrategy : IPaymentStrategy
{
    public void PayAsync(decimal price)
    {
        Console.WriteLine($"Você pagou com cartão de crédito: R$ {price}");
    }
}