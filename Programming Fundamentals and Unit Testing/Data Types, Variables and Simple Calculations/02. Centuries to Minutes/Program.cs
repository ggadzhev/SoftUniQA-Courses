int centuries = int.Parse(Console.ReadLine());


int centuryToYears = centuries * 100;
int yearsToDays = (int)(centuryToYears * 365.2422);
int daysToMinutes = yearsToDays * 24;
int hoursToMinutes = daysToMinutes * 60;


Console.WriteLine($"{centuries} centuries = {centuryToYears} " +
    $"years = {yearsToDays} days = {daysToMinutes} " +
    $"hours = {hoursToMinutes} minutes");
