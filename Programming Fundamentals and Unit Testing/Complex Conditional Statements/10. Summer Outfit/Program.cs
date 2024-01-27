int temperature = int.Parse(Console.ReadLine());
string dayTime = Console.ReadLine();

string shoes = "";
string outfit = "";

if (temperature >= 10 && temperature <= 18)
{
    if (dayTime == "Morning")
    {
        shoes = "Sneakers";
        outfit = "Sweatshirt";
    }
    else if (dayTime == "Afternoon" || dayTime == "Evening")
    {
        shoes = "Moccasins";
        outfit = "Shirt";
    }

}
else if (temperature > 18 && temperature <= 24)
{
    if (dayTime == "Morning")
    {
        shoes = "Moccasins";
        outfit = "Shirt";
    }
    else if (dayTime == "Afternoon")
    {
        shoes = "Sandals";
        outfit = "T-Shirt";
    }
    else if (dayTime == "Evening")
    {
        shoes = "Moccasins";
        outfit = "Shirt";
    }
}
else if (temperature >= 25)
{
    if (dayTime == "Morning")
    {
        shoes = "Sandals";
        outfit = "T-Shirt";
    }
    else if (dayTime == "Afternoon")
    {
        shoes = "Barefoot";
        outfit = "Swim Suit";
    }
    else if (dayTime == "Evening")
    {
        shoes = "Moccasins";
        outfit = "Shirt";
    }
}

Console.WriteLine($"It's {temperature} degrees, get your {outfit} and {shoes}.");