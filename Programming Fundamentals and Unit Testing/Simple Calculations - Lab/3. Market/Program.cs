double tomatoPrice = double.Parse(Console.ReadLine());
double tomatoQuantity = double.Parse(Console.ReadLine());
double cucumberPrice = double.Parse(Console.ReadLine());
double cucumberQuantity = double.Parse(Console.ReadLine());

double totalTomatoPrice = tomatoPrice * tomatoQuantity;
double totalCucumberPrice = cucumberPrice * cucumberQuantity;
double totalCostProducts = totalTomatoPrice + totalCucumberPrice;

Console.WriteLine($"{totalCostProducts:F2}");