int[] numbersOne = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int[] numbersTwo = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();


bool isIdentical = true;

for (int i = 0; i < numbersOne.Length; i++)
{
    if (numbersOne[i] != numbersTwo[i])
    {
        isIdentical = false; break;
    }
}

if (isIdentical)
{
    Console.WriteLine("Arrays are identical.");
}
else
{
    Console.WriteLine("Arrays are not identical.");
}
