/*
 * @author: Cesar Lopez
 * @copyright 2023 - All rights reserved
 */
namespace FunctionalCode;

public class Wallet
{
    private IList<Money> Content { get; } = new List<Money>();

    public void Add(Money money)
    {
        Content.Add(money);
    }

    public void Charge(Currency currency, decimal amount)
    {
        var moneys = this.Content.Select(money => money.Of(currency));
    }
}
