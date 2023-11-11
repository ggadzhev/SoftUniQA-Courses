
//input

double temperatureC = double.Parse(Console.ReadLine());

//calculations

double fahrenheitTemp = (temperatureC * 1.8) + 32;

//output

Console.WriteLine($"{fahrenheitTemp:F2}");
