//int hour = int.Parse(Console.ReadLine());
//string weekDay = Console.ReadLine();

//if (weekDay == "Monday" || weekDay == "Tuesday" || weekDay == "Wednesday" || weekDay == "Thursday" || weekDay == "Friday" || weekDay == "Saturday")
//{
//    if (hour >= 10 && hour <= 18)
//    {
//        Console.WriteLine("open");
//    }
//    else
//    {
//        Console.WriteLine("closed");
//    }
//}
//else if (weekDay == "Sunday")
//{
//    Console.WriteLine("closed");
//}
//--------------------------------------------------------------------------------------------------

int hour = int.Parse(Console.ReadLine());
string weekDay = Console.ReadLine();

switch (weekDay)
{
    case "Monday":
    case "Tuesday":
    case "Wednesday":
    case "Thursday":
    case "Friday":
    case "Saturday":

        if (hour >= 10 && hour <= 18)
        {
            Console.WriteLine("open");
        }
        else
        {
            Console.WriteLine("closed");
        }
        break;

    case "Sunday":
        Console.WriteLine("closed");
        break;
}

