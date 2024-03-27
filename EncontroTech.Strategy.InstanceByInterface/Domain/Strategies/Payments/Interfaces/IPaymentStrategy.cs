namespace EncontroTech.Strategy.InstanceByInterface.Domain.Strategies.Payments.Interfaces;

// É a interface que defini nossa estratégia(abstrata)
public interface IPaymentStrategy
{
    // Strategy - Interface
    // Ela não recebe a interface que é implementada pela compra
    // Ou seja, não tem mais conhecimento da implentação concreta de todos atributos, etc

    // Nossa estratégia esta recebendo uma interface que é implementa pela compra.
    // Ou seja, ela não tem conhecimento da implementação concreta de todos atributos, variaveis da classe compra, ela só tem conhecimento da interface pagavel
    // Caso outros contextos queria utilizar essa mesma estretragia, qualquer entidade do sistema que fosse pagavel
    // // Ao que pode ser pago, pode passar um processo de pagamento, poderia utilizar essas mesmas estratégias
    void PayAsync(IPayment order);
}