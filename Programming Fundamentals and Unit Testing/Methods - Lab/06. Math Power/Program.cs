int baseNumber = int.Parse(Console.ReadLine());
int power = int.Parse(Console.ReadLine());

Console.WriteLine(MathPower(baseNumber, power));
static int MathPower(int number, int powerNumber)
{
    int output = number;

    for (int i = 2; i <= powerNumber; i++)
    {
        output *= number;
    }

    return output;
}
