//input

double vegetablePricePerKilo = double.Parse(Console.ReadLine());
double fruitsPricePerKilo = double.Parse(Console.ReadLine());
int totalVegetableKilos = int.Parse(Console.ReadLine());
int totalFruitsKilo = int.Parse(Console.ReadLine());

//calculations

double euro = 0.194;

double totalVegetablePrice = vegetablePricePerKilo * totalVegetableKilos;
double totalFruitsPrice = fruitsPricePerKilo * totalFruitsKilo;
double totalAmount = totalVegetablePrice + totalFruitsPrice;
double amountInEuro = totalAmount / 1.94;


//output

Console.WriteLine($"{amountInEuro:F2}");