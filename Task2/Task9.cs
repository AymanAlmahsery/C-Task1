Console.WriteLine(reverseOdd("Bananas")); // Output: sananaB
Console.WriteLine(reverseOdd("One two three four")); // Output: enO owt eerht four

static string reverseOdd(string input)
{
    string[] words = input.Split(' ');

    for (int i = 0; i < words.Length; i++)
    {
        if (words[i].Length % 2 != 0)
        {
            words[i] = string.Concat(words[i].Reverse());
        }
    }

    return string.Join(" ", words);
}
