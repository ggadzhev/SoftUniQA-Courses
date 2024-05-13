string[] strings = Console.ReadLine().Split().ToArray();

string output = "";

foreach (string word in strings)
{
    for (int i = 0; i < word.Length; i++)
    {
        output += word;
    }

}

Console.WriteLine(output);
