string type = Console.ReadLine();

if (type == "int")
{
    int numberOne = int.Parse(Console.ReadLine());
    int numberTwo = int.Parse(Console.ReadLine());
    Console.WriteLine(GetGreaterInt(numberOne, numberTwo));
}
else if (type == "char")
{
    char firstChar = char.Parse(Console.ReadLine());
    char secondChar = char.Parse(Console.ReadLine());
    Console.WriteLine(GetGreaterChar(firstChar, secondChar));
}
else if (type == "string")
{
    string firstText = Console.ReadLine();
    string secondText = Console.ReadLine();
    Console.WriteLine(GetGreaterString(firstText, secondText));
}



static int GetGreaterInt(int number1, int number2)
    {
        if (number1 > number2) return number1;
        else return number2;
    }


static char GetGreaterChar(char char1, char char2)
{
    if (char1 > char2) return char1;
    else return char2;
}

static string GetGreaterString(string string1, string string2)
{
    if (string1 == string2) return string1;
    else return string2;
}
