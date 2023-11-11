// input

double sideA = double.Parse(Console.ReadLine());
double sideB = double.Parse(Console.ReadLine());
double height = double.Parse(Console.ReadLine());

//calculations

double trapeziodArea = (sideA + sideB) * height / 2;

//output

Console.WriteLine($"{trapeziodArea:f2}");