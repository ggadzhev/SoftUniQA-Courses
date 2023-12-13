string actorName = Console.ReadLine();
double academyPoints = double.Parse(Console.ReadLine());
int numberOfJudges = int.Parse(Console.ReadLine());


for (int i = 0; i < numberOfJudges; i++)
{
    string judgeName = Console.ReadLine();
    double judgePoints = double.Parse(Console.ReadLine());
    academyPoints += (judgeName.Length * judgePoints) / 2.0;

    if (academyPoints > 1250.5)
    {
       break;
    }
}
if (academyPoints > 1250.5)
{
    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {academyPoints:F1}!");
}
else
{
    Console.WriteLine($"Sorry, {actorName} you need {1250.5 - academyPoints:F1} more!");
}
