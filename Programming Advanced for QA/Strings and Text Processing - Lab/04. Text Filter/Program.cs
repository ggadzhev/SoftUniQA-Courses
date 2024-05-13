string[] wordFilter = Console.ReadLine().Split(", ").ToArray();
string text = Console.ReadLine();



foreach (string word in wordFilter)
{
    if (text.Contains(word))
    {
        string replacement = new string('*', wordFilter.Length);
        text = text.Replace(word, replacement);
    }


}

Console.WriteLine(text);