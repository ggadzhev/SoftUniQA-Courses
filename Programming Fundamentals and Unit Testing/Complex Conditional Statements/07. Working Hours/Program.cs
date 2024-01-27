int hourDay = int.Parse(Console.ReadLine());
string day = Console.ReadLine();

switch (day)
{
    case "Monday":
    case "Tuesday":
    case "Wednesday":
    case "Thursday":
    case "Friday":
    case "Saturday":
        if (hourDay >= 10 && hourDay <= 18)
            Console.WriteLine("open");
        else
            Console.WriteLine("closed");
        break;
   
}
if (day == "Sunday")
{
    Console.WriteLine("closed");
}
