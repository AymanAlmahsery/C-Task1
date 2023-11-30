int num1, num2;
Console.Write("Enter the first integer: ");
int.TryParse(Console.ReadLine(), out num1);
Console.Write("Enter the second integer: ");
int.TryParse(Console.ReadLine(), out num2);
int smallNu;
if (num1 < num2)
{
    smallNu = num1;
}
else
{
    smallNu = num2;
}

// Display the smaller number
Console.WriteLine($"The smaller number is: {smallNu}");