//

double movieBudget = double.Parse(Console.ReadLine());
int actorsCount = int.Parse(Console.ReadLine());
double clothesPricePerActor = double.Parse(Console.ReadLine());

double decorPrice = movieBudget * 0.10;
double clothesPrice = actorsCount * clothesPricePerActor;



if (actorsCount > 150)
{
    clothesPrice = clothesPrice - (clothesPrice * 0.10);
}

double totalMoviePrice = decorPrice + clothesPrice;

if (totalMoviePrice > movieBudget)
{
    // Ако парите за декора и дрехите са повече от бюджета
    Console.WriteLine("Not enough money!");
    Console.WriteLine($"Wingard needs {totalMoviePrice - movieBudget:F2} leva more.");
}
else
{
    
    Console.WriteLine("Action!");
    Console.WriteLine($"Wingard starts filming with {movieBudget - totalMoviePrice:F2} leva left.");
}


