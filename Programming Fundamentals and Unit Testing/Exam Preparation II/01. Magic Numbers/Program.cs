int n = int.Parse(Console.ReadLine());

bool noMagicNumbers = true;

for (int i = 1; i <= n; i++)
{
    int currentNumber = i;
	int sumDigits = 0;

	bool allDigitsPrime = true;

	while (currentNumber > 0)
	{
		int newNumber = currentNumber % 10;

		currentNumber = currentNumber / 10;

		sumDigits += newNumber;

		if (newNumber != 2 && newNumber != 3 && newNumber != 5 && newNumber != 7)
		{
			allDigitsPrime = false;
		}

	}
	if (allDigitsPrime && sumDigits % 2 == 0)
	{
        Console.WriteLine(i + " ");
		noMagicNumbers = false;
    }

}
if (noMagicNumbers)
{
    Console.WriteLine("no");
}
