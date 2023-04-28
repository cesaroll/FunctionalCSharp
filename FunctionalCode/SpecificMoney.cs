/*
 * @author: Cesar Lopez
 * @copyright 2023 - All rights reserved
 */
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
    }

    public class Empty : SpecificMoney
    {
        public Empty(Currency currency) : base(currency)
        {
        }

        public override decimal Withdraw()
        {
            throw new NotImplementedException();
        }
    }
}
