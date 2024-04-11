using EncontroTech.Strategy.Instance.Domain.Models;
using EncontroTech.Strategy.Instance.Domain.Strategies.Payments;
using EncontroTech.Strategy.Instance.Domain.Strategies.Payments.Interfaces;

namespace EncontroTech.Strategy.Instance;

public abstract class Program
{
    private static void Main()
    {
        Console.WriteLine("Tipos de Pagamento");

        Console.WriteLine("1. Cartão de Crédito");
        Console.WriteLine("2. Cartão de Débito");
        Console.WriteLine("3. Criptomoeda");
        Console.WriteLine("4. Boleto Bancário");

        Console.WriteLine("Escolha o tipo de pagamento: ");

        var paymentType = Convert.ToInt32(Console.ReadLine()?.Trim());

        const decimal price = 100.31m;

        var order = new Order(price, GetPaymentTypeStrategyFor(paymentType));

        order.ProcessOrder();
    }

    private static IPaymentStrategy GetPaymentTypeStrategyFor(int option)
    {
        return option switch
        {
            1 => new CreditCardPaymentStrategy(),
            2 => new DebitCardPaymentStrategy(),
            _ => throw new ArgumentException("This type of payment is not supported.")
        };
    }
}