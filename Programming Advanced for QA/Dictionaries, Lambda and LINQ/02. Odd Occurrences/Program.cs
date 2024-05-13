List<string> text = Console.ReadLine()
                     .ToLower()
                     .Split()
                     .ToList();

Dictionary<string, int> wordCounter = new Dictionary<string, int>();


foreach (string word in text)
{
    if (wordCounter.ContainsKey(word))
    {
        wordCounter[word]++;
    }
    else
    {
        wordCounter.Add(word, 1 );
    }
}

foreach (var pairs in wordCounter)
{
    if (pairs.Value % 2 != 0)
    {
        Console.Write(pairs.Key + " ");
    }
}

