int hours, minutes;

Console.Write("Input hours: ");
int.TryParse(Console.ReadLine(), out hours);

Console.Write("Input minutes: ");
int.TryParse(Console.ReadLine(), out minutes);

int totalMinutes = (hours * 60) + minutes;

Console.WriteLine($"Total: {totalMinutes} minutes.");