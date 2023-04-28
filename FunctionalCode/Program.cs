// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using FunctionalCode;

var card = new BankCard()
{
    ValidBefore = DateTime.Now.AddSeconds(2),
    Balance = 100
};


Console.WriteLine($"Available amount: {card.GetAvailableAmount(20)}"); // Returns 20
card.Balance = 15;
Console.WriteLine($"Available amount: {card.GetAvailableAmount(20)}"); // Returns 15
Thread.Sleep(3000);
Console.WriteLine($"Available amount: {card.GetAvailableAmount(20)}"); // Returns 0 (Non pure function)

