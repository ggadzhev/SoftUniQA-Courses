string word = "something";

static string StringReverse(string str)
{
    string reversedWord = string.Join("", str.ToCharArray().Reverse());

    return reversedWord;
}

Console.WriteLine(StringReverse(word));
