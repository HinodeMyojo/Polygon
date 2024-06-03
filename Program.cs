
using Polygon;

var creditCard = CreditCard.FromValue(1);

Console.WriteLine($"Disc for {creditCard} is {creditCard.Discount:P}");

Console.ReadLine();