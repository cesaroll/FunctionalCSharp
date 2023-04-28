/*
 * @author: Cesar Lopez
 * @copyright 2023 - All rights reserved
 */
namespace FunctionalCode;

public class BankCard
{
    public DateTime ValidBefore { get; set; }
    public decimal Balance { get; set; }

    public decimal GetAvailableAmount(decimal desired)
    {
        if (DateTime.Now.CompareTo(this.ValidBefore) >= 0)
            return 0;

        return Math.Min(this.Balance, desired);
    }
}
