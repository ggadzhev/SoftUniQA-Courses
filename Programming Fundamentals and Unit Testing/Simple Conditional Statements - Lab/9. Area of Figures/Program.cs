string figureType = Console.ReadLine();

if (figureType == "square")
{
    double sideA = double.Parse(Console.ReadLine());
    double area = sideA * sideA;
    Console.WriteLine($"{area:F2}");
}
else if (figureType == "rectangle")
{
    double sideA = double.Parse(Console.ReadLine());
    double sideB = double.Parse(Console.ReadLine());
    double area = sideA * sideB;
    Console.WriteLine($"{area:F2}");
}
else if (figureType == "circle")
{
    double radius = double.Parse(Console.ReadLine());
    double area = Math.PI * radius * radius;
    Console.WriteLine($"{area:F2}");
}
