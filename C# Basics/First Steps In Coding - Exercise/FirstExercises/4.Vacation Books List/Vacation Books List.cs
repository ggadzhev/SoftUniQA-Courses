//Input

using System.Xml.Schema;

int pagesAmount = int.Parse(Console.ReadLine());
int pagesPerHour = int.Parse(Console.ReadLine());
int totalDaysNeeded = int.Parse(Console.ReadLine());

// Calculations
//Общо време за четене на книгата: 212 страници / 20 страници за час = 10 часа общо
//Необходимите часове на ден: 10 часа / 2 дни = 5 часа на ден

int totalHours = pagesAmount / pagesPerHour;
int hoursPerDay = totalHours / totalDaysNeeded;



//Output

Console.WriteLine(hoursPerDay);

