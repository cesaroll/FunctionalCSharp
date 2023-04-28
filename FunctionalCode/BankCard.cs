/*
 * @author: Cesar Lopez
 * @copyright 2023 - All rights reserved
 */
namespace FunctionalCode;

public class BankCard
{
    public DateTime ValidBefore { get; }
    public decimal Balance { get; }

    public BankCard(DateTime validBefore, decimal balance)
    {
        this.ValidBefore = validBefore;
        this.Balance = balance;
    }

    public decimal GetAvailableAmount(decimal desired, DateTime at)
    {
        if (at.CompareTo(this.ValidBefore) >= 0)
            return 0;

        return Math.Min(this.Balance, desired);
    }
}
