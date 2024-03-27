using EncontroTech.Strategy.InstanceByInterface.Domain.Models;
using EncontroTech.Strategy.InstanceByInterface.Domain.Strategies.Payments.Interfaces;

namespace EncontroTech.Strategy.InstanceByInterface.Domain.Strategies.Payments;

// Estratégia - Concretas
// Aqui ela é concreta porque tem as implementações.
public sealed class CreditCardPaymentStrategy : IPaymentStrategy
{
    public void PayAsync(IPayment payment)
    {
        Console.WriteLine($"Você pagou com cartão de crédito: R$ {payment.GetValue()}");
    }
}