int count = int.Parse(Console.ReadLine());
          //word  //synonym
Dictionary<string, string> wordsWithSyn= new Dictionary<string, string>();



for (int i = 0; i < count; i++)
{
    string word = Console.ReadLine();
    string synonim = Console.ReadLine();


    if (wordsWithSyn.ContainsKey(word))
    {
        wordsWithSyn[word] += ", " + synonim;

    }
    else
    {
        wordsWithSyn.Add(word, synonim);
    }
}

foreach (var wordsPair in wordsWithSyn)
{
    Console.WriteLine($"{wordsPair.Key} - {wordsPair.Value}");
}

