string architectName = Console.ReadLine();
int totalProjects = int.Parse(Console.ReadLine());

int projectTime = 3;

int timeNeeded = totalProjects * projectTime;

Console.WriteLine($"The architect {architectName} " +
    $"will need {timeNeeded} hours to complete" +
    $" {totalProjects} " +
    $"project/s.");

