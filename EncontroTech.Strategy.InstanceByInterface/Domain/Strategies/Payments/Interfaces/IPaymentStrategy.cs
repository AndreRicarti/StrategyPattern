namespace EncontroTech.Strategy.InstanceByInterface.Domain.Strategies.Payments.Interfaces;

// Strategy - Interface
public interface IPaymentStrategy
{
    // Nossa estratégia esta recebendo uma interface que é implementa pelo pedido.
    // Ou seja, ela não tem conhecimento da implementação concreta de todos atributos, variaveis da classe compra, etc
    // Caso outros contextos queria utilizar essa mesma estretragia, qualquer entidade do sistema que fosse pagavel
    // Que pode ser pago, pode passar um processo de pagamento, poderia utilizar essas mesmas estratégias
    void PayAsync(IPayment order);
}