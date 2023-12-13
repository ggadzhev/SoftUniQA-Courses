double packageWeight = double.Parse(Console.ReadLine());
string typeOfService = Console.ReadLine();
int distance = int.Parse(Console.ReadLine());

double pricePerKilometer = 0;
double totalCost = 0;

if (typeOfService == "standard")
{
    if (packageWeight < 1)
    {
        pricePerKilometer = 0.03;
    }
    else if (packageWeight <= 10)
    {
        pricePerKilometer = 0.05;
    }
    else if (packageWeight <= 40)
    {
        pricePerKilometer = 0.10;
    }
    else if (packageWeight <= 90)
    {
        pricePerKilometer = 0.15;
    }
    else if (packageWeight <= 150)
    {
        pricePerKilometer = 0.20;
    }
    totalCost = pricePerKilometer * distance;
}
else if (typeOfService == "express")
{
    if (packageWeight < 1)
    {
        pricePerKilometer = 0.03 * 1.80;
    }
    else if (packageWeight <= 10)
    {
        pricePerKilometer = 0.05 * 1.40;
    }
    else if (packageWeight <= 40)
    {
        pricePerKilometer = 0.10 * 1.05;
    }
    else if (packageWeight <= 90)
    {
        pricePerKilometer = 0.15 * 1.02;
    }
    else if (packageWeight <= 150)
    {
        pricePerKilometer = 0.20 * 1.01;
    }

    double expressSurcharge = packageWeight * 0.02 * pricePerKilometer;
    double totalSurcharge = expressSurcharge * distance;
    totalCost = pricePerKilometer * distance + totalSurcharge;
}

Console.WriteLine($"The delivery of your shipment with weight of {packageWeight:F3} kg. would cost {totalCost:F2} lv.");