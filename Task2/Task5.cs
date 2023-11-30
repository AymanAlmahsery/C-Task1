double km, miles;
Console.Write("Input kilometers per hour: ");
double.TryParse(Console.ReadLine(), out km);

miles = km * 0.621371;

Console.WriteLine($"{km} kilometers per hour is equal to {miles} miles per hour.");
