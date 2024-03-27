using EncontroTech.Strategy.Instance.Domain.Models;
using EncontroTech.Strategy.Instance.Domain.Strategies.Payments.Interfaces;

namespace EncontroTech.Strategy.Instance.Domain.Strategies.Payments;

// Estratégia - Concretas
// Aqui ela é concreta porque tem as implementações.
public sealed class DebitCardPaymentStrategy : IPaymentStrategy
{
    public void PayAsync(Order order)
    {
        Console.WriteLine($"Você pagou com cartão de débito: R$ {order.Price}");
    }
}