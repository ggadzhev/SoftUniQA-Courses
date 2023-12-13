// input

int bestGoals = -1;
string bestPlayer = "";

string text = Console.ReadLine();

while (text != "END")
{
    int goals = int.Parse(Console.ReadLine());
    if (goals > bestGoals)
    {
        bestGoals = goals;
        bestPlayer = text;
    }
    if (goals >= 10) break;
    text = Console.ReadLine();
}

Console.WriteLine($"{bestPlayer} is the best player!");


//оutput
if (bestGoals >= 3)
{
    Console.WriteLine($"He has scored {bestGoals} goals and made a hat-trick !!!");
}
else
{
    Console.WriteLine($"He has scored {bestGoals} goals.");
}



