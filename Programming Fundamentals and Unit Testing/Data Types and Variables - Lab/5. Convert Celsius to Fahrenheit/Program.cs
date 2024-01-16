double tempCelsius = double.Parse(Console.ReadLine());

double tempFahrenheit = (tempCelsius * 1.8) + 32;

Console.WriteLine($"{tempFahrenheit:F2}");