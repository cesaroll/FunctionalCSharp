/*
 * @author: Cesar Lopez
 * @copyright 2023 - All rights reserved
 */
using System.ComponentModel.DataAnnotations;

namespace FunctionalCode;

public abstract class Money
{
    public abstract Money On(Timestamp time);
    public abstract SpecificMoney Of(Currency currency);
}
