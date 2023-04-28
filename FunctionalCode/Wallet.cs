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
        decimal remainingAmount = amount;
        using (IEnumerator<Money> money = this.Content.GetEnumerator())
        {
            while (money.MoveNext() && remainingAmount > 0)
            {
                var paid = money.Current.Withdraw(currency, remainingAmount);
                remainingAmount -= paid;
            }
        }
    }
}
