string seriesName = Console.ReadLine();
int seriesTimePerEpisode = int.Parse(Console.ReadLine());
int breakDuration = int.Parse(Console.ReadLine());

double lunchTime = breakDuration * 1.0 / 8.0;
double relaxTime = breakDuration * 1.0 / 4.0;
double remainingTime = breakDuration - lunchTime - relaxTime;

if (remainingTime >= seriesTimePerEpisode)
{
    Console.WriteLine($"You have enough time to watch {seriesName} and left with {Math.Ceiling(remainingTime - seriesTimePerEpisode)} minutes free time.");
}
else
{
    Console.WriteLine($"You don't have enough time to watch {seriesName}, you need {Math.Ceiling(seriesTimePerEpisode - remainingTime)} more minutes.");
}
