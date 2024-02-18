int n = Math.Abs(int.Parse(Console.ReadLine()));

Console.WriteLine(GetMultipleEvenOdds(n));
static int GetSumEvenDigits(int number)
{
    int evenSum = 0;

    while (number > 0)
    {
        int digit = number % 10;
        number = number / 10;
        if (digit % 2 == 0)
        {
            evenSum+=digit;
        }
    }
    return evenSum;
}
static int GetSumOddDigits(int number)
{
    int oddSum = 0;

    while (number > 0)
    {
        int digit = number % 10;
        number = number / 10;
        if (digit % 2 != 0)
        {
            oddSum+=digit;
        }
    }
    return oddSum;
}

static int GetMultipleEvenOdds(int number)
{
    return GetSumEvenDigits(number) * GetSumOddDigits(number);
}
