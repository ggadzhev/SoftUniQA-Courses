double recordInSeconds = double.Parse(Console.ReadLine());
double distanceInMeters = double.Parse(Console.ReadLine());
double swimmingTimeForOneMeter = double.Parse(Console.ReadLine());
double additionalTime = (distanceInMeters / 15) * 12.5;
double swimmingTime = distanceInMeters * swimmingTimeForOneMeter + additionalTime;

double totalTime = swimmingTime + additionalTime;

if (swimmingTime > recordInSeconds)
{
    Console.WriteLine($"No, he failed! He was {(swimmingTime - recordInSeconds):F2} seconds slower.");
}
else
{
    Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
}



