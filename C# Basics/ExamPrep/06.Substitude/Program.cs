// 06.Substitutions

int K = int.Parse(Console.ReadLine());
int L = int.Parse(Console.ReadLine());
int M = int.Parse(Console.ReadLine());
int N = int.Parse(Console.ReadLine());
int validCombinationCounter = 0;

// Calculations

for (int firstDigitOfFirstNum = K; firstDigitOfFirstNum <= 8; firstDigitOfFirstNum++)
{

    if (firstDigitOfFirstNum % 2 == 1)
    {
        continue;
    }

    for (int secondDigitOfFirstNum = 9; secondDigitOfFirstNum >= L; secondDigitOfFirstNum--)
    {

        if (secondDigitOfFirstNum % 2 == 0)
        {
            continue;
        }

        for (int firstDigitOfSecondNum = M; firstDigitOfSecondNum <= 8; firstDigitOfSecondNum++)
        {
            if (firstDigitOfSecondNum % 2 == 1)
            {

                continue;
            }


            for (int secondDigitOfSecondNum = 9; secondDigitOfSecondNum >= N; secondDigitOfSecondNum--)
            {
                if (secondDigitOfSecondNum % 2 == 0)
                {
                    continue;
                }
                if (firstDigitOfFirstNum == firstDigitOfSecondNum && secondDigitOfFirstNum == secondDigitOfSecondNum && validCombinationCounter < 6)
                {
                    Console.WriteLine("Cannot change the same player.");
                    continue;
                }
                if (validCombinationCounter == 6)
                {
                    break;
                }

                Console.WriteLine($"{firstDigitOfFirstNum}{secondDigitOfFirstNum} - {firstDigitOfSecondNum}{secondDigitOfSecondNum}");
                validCombinationCounter++;
            }
        }
    }
}