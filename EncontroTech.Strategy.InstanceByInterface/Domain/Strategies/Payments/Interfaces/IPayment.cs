namespace EncontroTech.Strategy.InstanceByInterface.Domain.Strategies.Payments.Interfaces;

// É uma interface para as estratégias não precise conhecer a classe concreta (Order)
// Você consegue limitar o que passar para suas estratégias
public interface IPayment
{
    decimal GetValue();
    // .. Poderia ter varios outros comportamentos
}