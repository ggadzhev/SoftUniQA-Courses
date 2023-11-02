int dogFoodPacks = int.Parse(Console.ReadLine());
int catFoodPacks = int.Parse(Console.ReadLine());


double dogFoodPrice = 2.50;
double catFoodPrice = 4.0;


double totalCost = (dogFoodPacks * dogFoodPrice) + (catFoodPacks * catFoodPrice);

Console.WriteLine($"{totalCost} lv.");