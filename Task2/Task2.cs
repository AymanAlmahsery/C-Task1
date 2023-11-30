int number;
Console.Write("Enter a number: ");
int.TryParse(Console.ReadLine(), out number);
if (number > 0)
{
    Console.WriteLine("The sign is +");
}
else if (number < 0)
{
    Console.WriteLine("The sign is -");
}
else
{
    Console.WriteLine("The number is zero");
}