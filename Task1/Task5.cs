int[] array = new int[10];

Console.WriteLine("Input 10 elements in the array:");
for (int i = 0; i < 10; i++)
{
    Console.Write($"element - {i} : ");
    int.TryParse(Console.ReadLine(), out array[i]);
}
Console.Write("Elements in array are: ");
for (int i = 0; i < 10; i++)
{
    Console.Write(array[i] + " ");
}
Console.WriteLine();