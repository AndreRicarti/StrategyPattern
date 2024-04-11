using EncontroTech.Strategy.InstanceByInterface.Domain.Strategies.Payments.Interfaces;

namespace EncontroTech.Strategy.InstanceByInterface.Domain.Strategies.Payments;

public sealed class DebitCardPaymentStrategy : IPaymentStrategy
{
    public void PayAsync(IPayment payment)
    {
        Console.WriteLine($"Você pagou com cartão de débito: R$ {payment.GetValue()}");
    }
}