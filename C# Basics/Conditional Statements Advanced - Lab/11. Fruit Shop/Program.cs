//string fruit = Console.ReadLine();
//string weekDay = Console.ReadLine();
//double amount = double.Parse(Console.ReadLine());

//double price = 0;

//switch (weekDay)
//{
//    case "Monday":
//    case "Tuesday":
//    case "Wednesday":
//    case "Thursday":
//    case "Friday":
//        switch (fruit)
//        {
//            case "banana": price = 2.50; break;
//            case "apple": price = 1.20; break;
//            case "orange": price = 0.85; break;
//            case "grapefruit": price = 1.45; break;
//            case "kiwi": price = 2.70; break;
//            case "pineapple": price = 5.50; break;
//            case "grapes": price = 3.85; break;
//        }
//break;
//}
//switch (weekDay)
//{
//    case "Saturday":
//    case "Sunday":
//        switch (fruit)
//        {
//            case "banana": price = 2.70; break;
//            case "apple": price = 1.25; break;
//            case "orange": price = 0.90; break;
//            case "grapefruit": price = 1.60; break;
//            case "kiwi": price = 3.00; break;
//            case "pineapple": price = 5.60; break;
//            case "grapes": price = 4.20; break;    
//        }
//break;
//}
//Console.WriteLine($"{price * amount:F2}");



using System.Transactions;

string fruit = Console.ReadLine().ToLower();
string weekDay = Console.ReadLine().ToLower();
double amount = double.Parse(Console.ReadLine());

double price = 0;

if (weekDay == "Monday" || weekDay == "Tuesday" || weekDay == "Wednesday" || weekDay == "Thursday" || weekDay == "Friday")
{
    if (fruit == "banana") price = 2.50;
    else if (fruit == "apple") price = 1.20;
    else if (fruit == "orange") price = 0.85;
    else if (fruit == "grapefruit") price = 1.45;
    else if (fruit == "kiwi") price = 2.70;
    else if (fruit == "pineapple") price = 5.50;
    else if (fruit == "grapes") price = 3.85;
}

else if (weekDay == "Saturday" || weekDay == "Sunday")
{
    if (fruit == "banana") price = 2.70;
    else if (fruit == "apple") price = 1.25;
    else if (fruit == "orange") price = 0.90;
    else if (fruit == "grapefruit") price = 1.60;
    else if (fruit == "kiwi") price = 3.00;
    else if (fruit == "pineapple") price = 5.60;
    else if (fruit == "grapes") price = 4.20;
    else
    {
        Console.WriteLine("error");
    }
}

