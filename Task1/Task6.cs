int[] array = new int[3];
Console.WriteLine("Enter elements into the array:");
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"index - {i} : ");
    int.TryParse(Console.ReadLine(), out array[i]);
}
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    sum += array[i];
}
Console.WriteLine($"Sum of all elements stored in the array is: {sum}");
