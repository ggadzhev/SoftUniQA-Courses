string season = Console.ReadLine();
string accommodation = Console.ReadLine();
int days = int.Parse(Console.ReadLine());

double pricePerNight = 0;
double discount = 0;

if (season == "Spring")
{
    discount = 0.2;

    if (accommodation == "Hotel")
    {
        pricePerNight = 30;
    }
    else if (accommodation == "Camping")
    {
        pricePerNight = 10;
    }
}
else if (season == "Summer")
{
    if (accommodation == "Hotel")
    {
        pricePerNight = 50;
    }
    else if (accommodation == "Camping")
    {
        pricePerNight = 30;
    }
}
else if (season == "Autumn")
{
    discount = 0.3;

    if (accommodation == "Hotel")
    {
        pricePerNight = 20;
    }
    else if (accommodation == "Camping")
    {
        pricePerNight = 15;
    }
}
else if (season == "Winter")
{
    discount = 0.1;

    if (accommodation == "Hotel")
    {
        pricePerNight = 40;
    }
    else if (accommodation == "Camping")
    {
        pricePerNight = 10;
    }
}

double totalPriceNoDiscount = pricePerNight * days;
double totalPrice = totalPriceNoDiscount - (totalPriceNoDiscount * discount);

Console.WriteLine($"{totalPrice:F2}");