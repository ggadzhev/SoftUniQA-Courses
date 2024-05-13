string word = Console.ReadLine();

Dictionary<char, int> stringDictionary = new Dictionary<char, int>();

foreach (char chars in word)
{

    if (chars != ' ')
    {
        if (stringDictionary.ContainsKey(chars))
        {
            stringDictionary[chars]++;
        }
        else
        {
            stringDictionary.Add(chars, 1);
        }
    }
}

foreach (var pairs in stringDictionary)
{
    Console.WriteLine($"{pairs.Key} -> {pairs.Value}");
}