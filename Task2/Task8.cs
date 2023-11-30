string[] sentences = new string[5];

sentences[0] = "This is a short sentence.";
sentences[1] = "This is a medium-length sentence.";
sentences[2] = "This is a longer sentence with more words.";
sentences[3] = "This is a very long sentence that contains a lot of words and characters.";
sentences[4] = "Short.";

int fixedLength = 30;

foreach (string sentence in sentences)
{
    Console.WriteLine(sentence.PadRight(fixedLength).Substring(0, fixedLength));
}