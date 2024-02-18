
int number = int.Parse(Console.ReadLine());

NumSign(number);
static void NumSign(int n)
{

    if (n == 0)
    {
        Console.WriteLine($"The number {n} is zero.");
    }
    else if (n > 0)
    {
        Console.WriteLine($"The number {n} is positive.");
    }
    else
    {
        Console.WriteLine($"The number {n} is negative.");
    }


}
