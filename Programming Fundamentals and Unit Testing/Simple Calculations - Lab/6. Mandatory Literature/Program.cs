int numberOfPages = int.Parse(Console.ReadLine());
int pagesRead = int.Parse(Console.ReadLine());
int daysNeeded = int.Parse(Console.ReadLine());

int totalReadingTime = numberOfPages / pagesRead;
int totalHoursReading = totalReadingTime / daysNeeded;

Console.WriteLine(totalHoursReading);