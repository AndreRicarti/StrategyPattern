using EncontroTech.Strategy.Instance.Domain.Models;

namespace EncontroTech.Strategy.Instance.Domain.Strategies.Payments.Interfaces;

public interface IPaymentStrategy
{
    // Ao invés de passar um atributo, eu passo a instância completa da compra
    void PayAsync(Order order);
}