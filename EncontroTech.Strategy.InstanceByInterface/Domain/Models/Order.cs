using EncontroTech.Strategy.InstanceByInterface.Domain.Strategies.Payments.Interfaces;

namespace EncontroTech.Strategy.InstanceByInterface.Domain.Models;

// Contexto - É a classe que vai utilizar a estratégia
// Ao inves de passar a compra inteira, pode ter varias coisas que não quero passar para minha interface(estratégia)
public abstract class Order : IPayment
{
    private decimal Price { get; set; }

    protected Order(decimal price)
    {
        Price = price;
    }

    // Nossa compra implementa essa estratégia
    // E na hora de chamar a estratégia, ela passa ela mesma, ela se passa como uma instância para nossa estratégia
    public void ProcessOrder(IPaymentStrategy paymentStrategy)
    {
        paymentStrategy.PayAsync(this);
    }

    public decimal GetValue()
    {
        return Price;
    }
}