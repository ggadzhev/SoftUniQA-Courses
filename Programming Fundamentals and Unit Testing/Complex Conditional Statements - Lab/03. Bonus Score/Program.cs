int points = int.Parse(Console.ReadLine());

int bonusPoints = 0;
int totalPoitsWithBonus = 0;

if (points >= 0 && points <= 3)
{
    bonusPoints = 5;
    totalPoitsWithBonus = points + bonusPoints;
}
else if (points >= 4 && points <= 6)
{
    bonusPoints = 15;
    totalPoitsWithBonus = points + bonusPoints;
}
else if (points >= 7 && points <= 9)
{
    bonusPoints = 20;
    totalPoitsWithBonus = points + bonusPoints;
}
Console.WriteLine(totalPoitsWithBonus);
