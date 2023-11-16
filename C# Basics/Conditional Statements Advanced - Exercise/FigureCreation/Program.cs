int sideA = int.Parse(Console.ReadLine());
int sideB = int.Parse(Console.ReadLine());
int sideC = int.Parse(Console.ReadLine());


if (sideA == sideB && sideA == sideC)
{
    Console.WriteLine("   /\\");
    Console.WriteLine("  /  \\");
    Console.WriteLine(" /    \\");
    Console.WriteLine("--------");
}

else if (sideA != sideB && sideA < sideC)
{
    Console.WriteLine("     /|");
    Console.WriteLine("    / |");
    Console.WriteLine("   /  |");
    Console.WriteLine("  /   |");
    Console.WriteLine(" /    |");
    Console.WriteLine("/     |");
    Console.WriteLine("-------");
}
else if (sideA < sideB && sideA > sideC)
{
    Console.WriteLine("|\\");
    Console.WriteLine("| \\");
    Console.WriteLine("|  \\");
    Console.WriteLine("|   \\");
    Console.WriteLine("|    \\");
    Console.WriteLine("|     \\");
    Console.WriteLine("--------");
}
else if ((sideA + sideB) < sideC)
{
    Console.WriteLine("Not a triangle");
}