string text = Console.ReadLine();

string digits = "";
string letters = "";
string otherSymbols = "";



foreach (char ch in text)
{
    if (char.IsDigit(ch))
    {
        digits += ch;
    }
    else if (char.IsLetter(ch))
    {
        letters += ch;
    }
    else
    {
        otherSymbols += ch;
    }
}

Console.WriteLine(digits);
Console.WriteLine(letters);
Console.WriteLine(otherSymbols);