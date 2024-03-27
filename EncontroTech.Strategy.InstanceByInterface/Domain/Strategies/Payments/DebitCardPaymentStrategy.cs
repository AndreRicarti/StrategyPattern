//using EncontroTech.Strategy.Domain.Models;
//using EncontroTech.Strategy.InstanceByInterface.Domain.Strategies.Payments.Interfaces;

//namespace EncontroTech.Strategy.InstanceByInterface.Domain.Strategies.Payments;

//// Estratégia - Concretas
//// Aqui ela é concreta porque tem as implementações.
//public sealed class DebitCardPaymentStrategy : IPaymentStrategy
//{
//    public void PayAsync(Order order)
//    {
//        Console.WriteLine($"You paid by debit card: R$ {order.Value}");
//    }

//    public void PayAsync(IPayment payment)
//    {
//        throw new NotImplementedException();
//    }
//}