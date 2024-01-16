int packagesDogFood = int.Parse(Console.ReadLine());
int packagesCatFood = int.Parse(Console.ReadLine());

double dogFoodPrice = packagesDogFood * 2.50;
double catFoodPrice = packagesCatFood * 4.00;

double expences = dogFoodPrice + catFoodPrice;

Console.WriteLine($"{expences:F2} lv.");