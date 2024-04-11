using EncontroTech.Strategy.Instance.Domain.Models;
using EncontroTech.Strategy.Instance.Domain.Strategies.Payments.Interfaces;

namespace EncontroTech.Strategy.Instance.Domain.Strategies.Payments;

// Estratégia - Concretas
public sealed class CreditCardPaymentStrategy : IPaymentStrategy
{
    // Aqui eu tenho o acesso a compra inteira para poder trabalhar com ela
    // Da flexibilidade maior no tratamento da compra
    // Porém aumenta a complexibilidade, diminui o encapsulamento daquele comportamento, pois pode ter um efeito colateral.
    // Agora eu criei um vínculo maior, as estratégias precisa conhecer a compra
    public void PayAsync(Order order)
    {
        // order.Status = Paid

        Console.WriteLine($"Você pagou com cartão de crédito: R$ {order.Price}");
    }
}