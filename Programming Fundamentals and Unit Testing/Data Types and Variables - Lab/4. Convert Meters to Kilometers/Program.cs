double distanceMeters = double.Parse(Console.ReadLine());

double kilometer = 1000;
double metersPerKilometer = distanceMeters / kilometer;

Console.WriteLine($"{metersPerKilometer:F2}");

