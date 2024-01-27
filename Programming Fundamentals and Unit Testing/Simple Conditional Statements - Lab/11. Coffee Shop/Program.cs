string drinkName = Console.ReadLine();
string extra = Console.ReadLine();

double coffeePrice = 1.00;
double teaPrice = 0.60;
double sugarPrice = 0.40;
double finalPrice = 0.00;

if (drinkName == "coffee" && extra == "sugar")
{
    finalPrice = coffeePrice + sugarPrice;
}
else if (drinkName == "coffee" && extra == "no")
{
    finalPrice = coffeePrice;
}
else if (drinkName == "tea" && extra == "sugar")
{
    finalPrice = teaPrice + sugarPrice;
}
else if (drinkName == "tea" && extra == "no")
{
    finalPrice = teaPrice;
}

Console.WriteLine($"Final price: ${finalPrice:F2}");
