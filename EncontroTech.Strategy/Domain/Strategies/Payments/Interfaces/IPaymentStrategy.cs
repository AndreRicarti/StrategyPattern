﻿namespace EncontroTech.Strategy.Dados.Domain.Strategies.Payments.Interfaces;

public interface IPaymentStrategy
{
    // Strategy - Interface (É uma interface abstrata porque não tem implementação)
    // É a interface onde declaramos o método
    // Esse método vai encapsular o algoritmo, comportamento
    // Geralmente tem 2 ou mais implementação da interface
    // Vai definir o contrato da nossa estratégia, ela serve para que
    // É a interface que defini a estratégia de pagamento
    void PayAsync(decimal price);
}