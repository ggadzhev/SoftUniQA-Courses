string product = Console.ReadLine();
int quantity = int.Parse(Console.ReadLine());

double finalPrice = GetFinalPrice(product, quantity);

Console.WriteLine($"{finalPrice:F2}");

static double GetFinalPrice(string prod, int quant)
{
    double singleProductPrice = 0;
    if (prod == "coffee")
    {
        singleProductPrice = 1.50;
    }
    else if (prod == "water")
    {
        singleProductPrice = 1.00;
    }
    else if (prod == "coke")
    {
        singleProductPrice = 1.40;
    }
    else if (prod == "snacks")
    {
        singleProductPrice = 2.00;
    }
    return singleProductPrice * quant;
}
