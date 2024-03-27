using EncontroTech.Strategy.Instance.Domain.Models;
using EncontroTech.Strategy.Instance.Domain.Strategies.Payments.Interfaces;

namespace EncontroTech.Strategy.Instance.Domain.Strategies.Payments;

// Estratégia - Concretas
// Aqui eu tenho o acesso a compra inteira para poder trabalhar com ela
// Da flexibilidade maior no tratamento da compra
// Porém aumenta a complexibilidade, diminui o encapsulamento daquele comportamento, pois pode ter um efeito colateral.
// Agora eu criei um vínculo maior, as estratégias precisa conhecer a compra

public sealed class CreditCardPaymentStrategy : IPaymentStrategy
{
    public void PayAsync(Order order)
    {
        Console.WriteLine($"Você pagou com cartão de crédito: R$ {order.Price}");
    }
}