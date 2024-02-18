List<int> numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

for (int i = 0; i < numbers.Count; i++)
{
    int currentNumber = numbers[i];  
    if (currentNumber < 0)
    {
        numbers.Remove(currentNumber);          // delete the negative number, next index is filled with the next number in the list
        i--;                                    // return one index back to check if new number in the new index isn't negati ve

    }
}

if (numbers.Count > 0)
{
    numbers.Reverse();
    Console.WriteLine(string.Join(" ", numbers));
}
else
{
    Console.WriteLine("empty");
}
