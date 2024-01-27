int sideA = int.Parse(Console.ReadLine());
int sideB = int.Parse(Console.ReadLine());
int sideC = int.Parse(Console.ReadLine());

if (sideA < sideB + sideC)
{
    Console.WriteLine("Valid Triangle");
}
else if (sideB < sideA + sideC)
{
    Console.WriteLine("Valid Triangle");
}
else if (sideC < sideA + sideB)
{
    Console.WriteLine("Valid Triangle");
}
else
{
    Console.WriteLine("Invalid Triangle");
}
