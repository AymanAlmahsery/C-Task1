int num1, num2, num3, num4, num5;

Console.Write("Enter first number: ");
int.TryParse(Console.ReadLine(), out num1);

Console.Write("Enter second number: ");
int.TryParse(Console.ReadLine(), out num2);

Console.Write("Enter third number: ");
int.TryParse(Console.ReadLine(), out num3);

Console.Write("Enter fourth number: ");
int.TryParse(Console.ReadLine(), out num4);

Console.Write("Enter fifth number: ");
int.TryParse(Console.ReadLine(), out num5);

int maxNu = num1;

if (num2 > maxNu)
{
    maxNu = num2;
}

if (num3 > maxNu)
{
    maxNu = num3;
}

if (num4 > maxNu)
{
    maxNu = num4;
}

if (num5 > maxNu)
{
    maxNu = num5;
}
Console.WriteLine($"The maximum number is: {maxNu}");