string weekDay = Console.ReadLine();


int ticketPrice = 0;

if (weekDay == "Monday" || weekDay == "Tuesday" || weekDay == "Friday")
{
    ticketPrice = 12;
    Console.WriteLine(ticketPrice);
}
else if (weekDay == "Wednesday" || weekDay == "Thursday")
{
    ticketPrice = 14;
    Console.WriteLine(ticketPrice);
}
else if (weekDay == "Saturday" || weekDay == "Sunday")
{
    ticketPrice = 16;
    Console.WriteLine(ticketPrice);
}

//////////  Secondary solution
string weekDay = Console.ReadLine();


if (weekDay == "Monday" || weekDay == "Tuesday" || weekDay == "Friday")
{
    
    Console.WriteLine(12);
}
else if (weekDay == "Wednesday" || weekDay == "Thursday")
{
    
    Console.WriteLine(14);
}
else if (weekDay == "Saturday" || weekDay == "Sunday")
{
   
    Console.WriteLine(16);
}
