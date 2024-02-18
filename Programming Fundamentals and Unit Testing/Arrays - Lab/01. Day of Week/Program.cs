string[] days = new string[7];

days[0] = "Monday";
days[1] = "Tuesday";
days[2] = "Wednesday";
days[3] = "Thursday";
days[4] = "Friday";
days[5] = "Saturday";
days[5] = "Sunday";

string[] moreDays =
{
    "Invalid day!", //0
    "Monday",       //1
    "Tuesday",      //2
    "Wednesday",    //3
    "Thursday",     //4
    "Friday",      //5
    "Saturday",    //6
    "Sunday"      // 7
    
};

int currentDay = int.Parse(Console.ReadLine());

if (currentDay >= 1 && currentDay <= 7)
{
    Console.WriteLine(moreDays[currentDay]);
    
}
else
{
    Console.WriteLine(moreDays[0]);
}
