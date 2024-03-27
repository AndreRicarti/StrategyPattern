using EncontroTech.Strategy.Instance.Domain.Strategies.Payments.Interfaces;

namespace EncontroTech.Strategy.Instance.Domain.Models;

// Contexto - É a classe que vai utilizar a estratégia
public sealed class Order
{
    public decimal Price { get; set; }

    public Order(decimal price)
    {
        Price = price;
    }

    // Esse método recebe a estratégia de pagamento
    // Quem for chamar esse método de processar compra, vai definir que vai ser utilizado
    public void ProcessOrder(IPaymentStrategy paymentStrategy)
    {
        paymentStrategy.PayAsync(this);
    }
}