using EncontroTech.Strategy.Dados.Domain.Strategies.Payments.Interfaces;

namespace EncontroTech.Strategy.Dados.Domain.Models;

// Contexto - É a classe que vai utilizar a estratégia
public sealed class Order(
    decimal price, 
    IPaymentStrategy paymentStrategy)
{
    private IPaymentStrategy PaymentStrategy { get; } = paymentStrategy;

    private decimal Price { get; } = price;

    // Esse método recebe a estratégia de pagamento
    // Quem for chamar esse método de processar compra, vai definir que vai ser utilizado
    public void ProcessOrder()
    {
        // Aqui vai ter validações, chamada de endpoint, etc
        PaymentStrategy.PayAsync(Price);
    }
}