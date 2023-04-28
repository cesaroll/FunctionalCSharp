/*
 * @author: Cesar Lopez
 * @copyright 2023 - All rights reserved
 */
namespace FunctionalCode;

public class Wallet
{
    private IList<Money> Content { get; set; } = new List<Money>();

    public void Add(Money money)
    {
        Content.Add(money);
    }

    public Amount Charge(Currency currency, Amount toCharge)
    {
        var split = this.Content
            .Select(money => money.On(Timestamp.Now))
            .Select(money => money.Of(currency))
            .Take(toCharge.Value)
            .ToList();

        this.Content = split.ConvertAll(tuple => tuple.Item2);

        var total = split.Sum(tuple => tuple.Item1.Value);
        return new Amount(toCharge.Currency, total);
    }
}
