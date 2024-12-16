using EncontroTech.Strategy.Dados.Domain.Strategies.Payments.Interfaces;

namespace EncontroTech.Strategy.Dados.Domain.Strategies.Payments;

// Estratégia - Concretas
public sealed class DebitCardPaymentStrategy : IPaymentStrategy
{
    public void PayAsync(decimal price)
    {
        Console.WriteLine($"You paid by debit card: R$ {price}");
    }
}