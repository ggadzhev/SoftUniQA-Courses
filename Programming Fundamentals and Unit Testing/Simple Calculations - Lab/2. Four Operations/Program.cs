double numberOne = double.Parse(Console.ReadLine());
double numberTwo = double.Parse(Console.ReadLine());

double adding = numberOne + numberTwo;
double substraction = numberOne - numberTwo;
double multiplication = numberOne * numberTwo;
double division = numberOne / numberTwo;

Console.WriteLine($"{numberOne:F2} + {numberTwo:F2} = {adding:F2}");
Console.WriteLine($"{numberOne:F2} - {numberTwo:F2} = {substraction:F2}");
Console.WriteLine($"{numberOne:F2} * {numberTwo:F2} = {multiplication:F2}");
Console.WriteLine($"{numberOne:F2} / {numberTwo:F2} = {division:F2}");


