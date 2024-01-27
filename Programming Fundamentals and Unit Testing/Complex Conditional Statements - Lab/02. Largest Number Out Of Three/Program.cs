int numberOne = int.Parse(Console.ReadLine());
int numberTwo = int.Parse(Console.ReadLine());
int numberThree = int.Parse(Console.ReadLine());

if (numberOne > numberTwo)
{
    if (numberOne > numberThree)
    {
        Console.WriteLine(numberOne);
    }
    else
    {
        Console.WriteLine(numberThree);
    }
}
else
{
    if (numberTwo > numberThree)
    {
        Console.WriteLine(numberTwo);
    }
    else
    {
        Console.WriteLine(numberThree);
    }
}
