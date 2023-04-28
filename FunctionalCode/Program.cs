// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using FunctionalCode;

var card = new BankCard(DateTime.Now.AddSeconds(2), 100);


Console.WriteLine($"Available amount: {card.GetAvailableAmount(20, DateTime.Now)}"); // Returns 20

Console.WriteLine($"Available amount: {card.GetAvailableAmount(20, DateTime.Now)}"); // Returns 20
Thread.Sleep(3000);
Console.WriteLine($"Available amount: {card.GetAvailableAmount(20, DateTime.Now)}"); // Returns 0

