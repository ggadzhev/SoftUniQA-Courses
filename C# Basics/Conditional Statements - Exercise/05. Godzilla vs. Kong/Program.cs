//

double movieBudget = double.Parse(Console.ReadLine());
int actorsCount = int.Parse(Console.ReadLine());
double clothesPricePerActor = double.Parse(Console.ReadLine());

double decorPrice = movieBudget * 0.10;
double clothesPrice = actorsCount * clothesPricePerActor;
double totalMoviePrice = decorPrice + clothesPrice;
double discountClothes = clothesPrice * 0.10;

if (totalMoviePrice > movieBudget)
{
    double moneyNeeded = movieBudget - totalMoviePrice;
    Console.WriteLine($"Not enough money!");
    Console.WriteLine($"Wingard needs {moneyNeeded:F2} leva more.");
}
else if (actorsCount > 150)
{
    double totalPriceMovie = movieBudget - (clothesPrice - discountClothes);
    double moneyNeeded = movieBudget - totalPriceMovie;

    Console.WriteLine($" Action!");
    Console.WriteLine($" Wingard starts filming with {moneyNeeded:F2} leva left.");
}
