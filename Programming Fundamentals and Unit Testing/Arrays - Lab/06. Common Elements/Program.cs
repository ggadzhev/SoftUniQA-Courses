int[] numbersOne = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int[] numbersTwo = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();



for (int i = 0; i < numbersOne.Length; i++)
{
    for (int j = 0; j < numbersTwo.Length; j++)
    {
        if (numbersOne[i] == numbersTwo[j])
        {
            Console.Write($"{numbersOne[i]} ");
        }
    }
}
Console.WriteLine();
