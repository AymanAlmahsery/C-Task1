int num1, num2, num3;

Console.Write("Enter first number: ");
int.TryParse(Console.ReadLine(), out num1);

Console.Write("Enter second number: ");
int.TryParse(Console.ReadLine(), out num2);

Console.Write("Enter third number: ");
int.TryParse(Console.ReadLine(), out num3);

if (num1 > num2)
{
    int temp = num1;
    num1 = num2;
    num2 = temp;
}
if (num2 > num3)
{
    int temp = num2;
    num2 = num3;
    num3 = temp;
    if (num1 > num2)
    {
        int temp2 = num1;
        num1 = num2;
        num2 = temp2;
    }
}
Console.WriteLine($"Sorted numbers in ascending order: {num1}, {num2}, {num3}");