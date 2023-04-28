/*
 * @author: Cesar Lopez
 * @copyright 2023 - All rights reserved
 */
using System.Runtime;

namespace FunctionalCode
{
    public abstract class SpecificMoney : Money
    {
        public Currency Currency { get; set; }

        public SpecificMoney(Currency currency)
        {
            this.Currency = currency;
        }

        public override SpecificMoney Of(Currency currency)
        {
            if (currency.Equals(this.Currency))
                return this;
            return new Empty(currency);
        }

        public abstract Tuple<Amount, Money> Take(decimal amount);
    }

    public class Empty : SpecificMoney
    {
        public Empty(Currency currency) : base(currency)
        {
        }

        public override Money On(Timestamp time)
        {
            throw new NotImplementedException();
        }

        public override Tuple<Amount, Money> Take(decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}
