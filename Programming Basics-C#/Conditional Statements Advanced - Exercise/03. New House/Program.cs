string flowers = (Console.ReadLine());
int flowersAmount = int.Parse(Console.ReadLine());
int budget = int.Parse(Console.ReadLine());

//double rosePrice = 5;
//double dahliaPrice = 3.80;
//double tulipsPrice = 2.80;
//double narcissusPrice = 3.00;
//double gladiolusPrice = 2.50;
double price = 0.0;

switch (flowers)
{
    case "Roses": price = 5; break;
    case "Dahlias": price = 3.80; break;
    case "Tulips": price = 2.80; break;
    case "Narcissus": price = 3.00; break;
    case "Gladiolus": price = 2.50; break;
}
double totalCost = flowersAmount * price;

if (flowers == "Roses" && flowersAmount > 80)
{
    totalCost = totalCost * 0.9;
}
else if (flowers == "Dahlias" && flowersAmount > 90)
{
    totalCost = totalCost * 0.85;   
}
else if (flowers == "Tulips" && flowersAmount > 80)
{
    totalCost = totalCost * 0.85;
}
else if (flowers == "Narcissus" && flowersAmount < 120)
{
    totalCost = totalCost * 1.15 ;
}
else if (flowers == "Gladiolus" && flowersAmount < 80)
{
    totalCost = totalCost * 1.2;
}


if (totalCost <= budget)
{
    double diff = budget - totalCost;
    Console.WriteLine($"Hey, you have a great garden with {flowersAmount} {flowers} and {diff:F2} leva left.");

}
else
{
    double moneyRequired = totalCost - budget;
    Console.WriteLine($"Not enough money, you need {moneyRequired:F2} leva more.");
}


//Console.WriteLine($"{diff:F2}");
