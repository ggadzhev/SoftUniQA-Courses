//string town = Console.ReadLine();
//double quantity = double.Parse(Console.ReadLine());

//double commission = 0;

//if (town == "Sofia")
//{
//    if (quantity > 0 && quantity <= 500)
//    {
//        commission = quantity * 0.05;
//    }
//    else if (quantity > 500 && quantity <= 1000)
//    {
//        commission = quantity * 0.07;
//    }
//    else if (quantity > 1000 && quantity <= 10000)
//    {
//        commission = quantity * 0.08;
//    }
//    else if (quantity > 10000)
//    {
//        commission = quantity * 0.12;
//    }
//    else
//    {
//        Console.WriteLine("error");
//    }

//}
//else if (town == "Varna")
//{
//    if (quantity > 0 && quantity <= 500)
//    {
//        commission = quantity * 0.045;
//    }
//    else if (quantity > 500 && quantity <= 1000)
//    {
//        commission = quantity * 0.075;
//    }
//    else if (quantity > 1000 && quantity <= 10000)
//    {
//        commission = quantity * 0.10;
//    }
//    else if (quantity > 10000)
//    {
//        commission = quantity * 0.13;
//    }
//    else
//    {
//        Console.WriteLine("error");
//    }

//}
//else if (town == "Plovdiv")
//{
//    if (quantity > 0 && quantity <= 500)
//    {
//        commission = quantity * 0.055;
//    }
//    else if (quantity > 500 && quantity <= 1000)
//    {
//        commission = quantity * 0.08;
//    }
//    else if (quantity > 1000 && quantity <= 10000)
//    {
//        commission = quantity * 0.12;
//    }
//    else if (quantity > 10000)
//    {
//        commission = quantity * 0.145;
//    }
//    else
//    {
//        Console.WriteLine("error");
//    }

//}
//Console.WriteLine($"{commission:F2}");

string town = Console.ReadLine();
double quantity = double.Parse(Console.ReadLine());
double commission = 0;

switch (town)
{
    case "Sofia":
        if (quantity < 0)
        {
            Console.WriteLine("error");
        }
        else if (quantity >= 0 && quantity <= 500)
        {
            commission = quantity * 0.05;
        }
        else if (quantity > 500 && quantity <= 1000)
        {
            commission = quantity * 0.07;
        }
        else if (quantity > 1000 && quantity <= 10_000)
        {
            commission = quantity * 0.08;
        }
        else
            commission = quantity * 0.12;
        break;

    case "Varna":
    if (quantity < 0)
    {
        Console.WriteLine("error");
    }
    else if (quantity <= 500)
        {

            commission = quantity * 0.045;
        }
        else if (quantity <= 1000)
        {

            commission = quantity * 0.075;
        }
        else if (quantity <= 10000)
        {

            commission = quantity * 0.10;
        }
        else
        {

            commission = quantity * 0.13;
        }
    break;


case "Plovdiv":
    if (quantity < 0)
    {
        Console.WriteLine("error");
    }
    else if (quantity <= 500)
        {

            commission = quantity * 0.055;
        }
        else if (quantity <= 1000)
        {

            commission = quantity * 0.08;
        }
        else if (quantity <= 10000)
        {

            commission = quantity * 0.12;
        }
        else
        {

            commission = quantity * 0.145;
        }
        break;

}

if (town != "Sofia" || town != "Varna" || town != "Plovdiv" && quantity < 0)
{
    Console.WriteLine("error");
}
else if (town == "Sofia" || town == "Varna" || town == "Plovdiv")
{
    Console.WriteLine($"{commission:F2}");
}
