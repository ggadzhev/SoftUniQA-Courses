double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();

string vacationDestination;


if (budget <= 100)
{
    vacationDestination = "Bulgaria";
}
else if (budget <= 1000)
{
    vacationDestination = "Balkans";
}
else 
{
    vacationDestination = "Europe";
}
double percentageBudget = 0;



switch (vacationDestination)
{
    case "Bulgaria":
        switch (season)
        {
            case "summer":
                percentageBudget = 0.3;
            break;

            case "winter":
                percentageBudget = 0.7;
            break;
            
        }
        break;
    case "Balkans":
        switch (season)
        {
            case "summer":
                percentageBudget = 0.4;
                break;

            case "winter":
                percentageBudget = 0.8;
                break;

        }
        break;
    case "Europe":
        percentageBudget = 0.9;
        break;
        }
}


