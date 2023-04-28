/*
 * @author: Cesar Lopez
 * @copyright 2023 - All rights reserved
 */
namespace FunctionalCode;

public abstract class Money
{
    public abstract SpecificMoney Of(Currency currency);
    public abstract Decimal Withdraw();
}
