int totalMinutes;

Console.Write("Input minutes: ");
int.TryParse(Console.ReadLine(), out totalMinutes);

int hours = totalMinutes / 60;
int remainingMinutes = totalMinutes % 60;

Console.WriteLine($"{hours} Hours, {remainingMinutes} Minutes");
