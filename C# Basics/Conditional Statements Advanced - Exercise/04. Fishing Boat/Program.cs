int groupBudget = int.Parse(Console.ReadLine());
string season = Console.ReadLine();
int fishers = int.Parse(Console.ReadLine());

double boatPrice = 0;

switch (season)
{
    case "Spring": boatPrice = 3000; break;
    case "Summer":
    case "Autumn":
        boatPrice = 4200; break;
    case "Winter": boatPrice = 2600; break;
}

if (fishers <= 6)
{
    boatPrice *= 0.9;
}
else if (fishers <= 11)
{
    boatPrice *= 0.85;
}
else
{
    boatPrice *= 0.75;
}

if (fishers % 2 == 0 && season != "Autumn")
{
    boatPrice *= 0.95;
}

if (groupBudget >= boatPrice)
{
    Console.WriteLine($"Yes! You have {(groupBudget - boatPrice):F2} leva left.");
}
else 
{

    Console.WriteLine($"Not enough money! You need {(boatPrice - groupBudget):F2} leva.");
}
