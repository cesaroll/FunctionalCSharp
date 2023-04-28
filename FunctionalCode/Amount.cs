/*
 * @author: Cesar Lopez
 * @copyright 2023 - All rights reserved
 */
namespace FunctionalCode;

public class Amount
{
    public Currency Currency { get; }
    public decimal Value { get; }

    public Amount(Currency currency, decimal value)
    {
        this.Currency = currency;
        this.Value = value;
    }

}
