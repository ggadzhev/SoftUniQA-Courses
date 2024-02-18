string text = Console.ReadLine();
int number = int.Parse(Console.ReadLine());

Console.WriteLine(RepeatString(text, number));
static string RepeatString(string input, int count)
{
    string output = "";

    for (int i = 1; i <= count; i++)
    {
        output += input;
    }


    return output;
}
