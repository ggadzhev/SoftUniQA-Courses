List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// Call the method to find and display odd and even numbers
DisplayOddAndEvenNumbers(numbers);


 static void DisplayOddAndEvenNumbers(List<int> numbers) // Method to split even and odd numbers in a list
{
    List<int> oddNumbers = new List<int>();
    List<int> evenNumbers = new List<int>();

    foreach (var number in numbers) // for each number in "numbers" list check which are Even and add them in list, else add in odds
    {
        if (number % 2 == 0)
        {
            evenNumbers.Add(number);
        }
        else
        {
            oddNumbers.Add(number);
        }
    }

    Console.WriteLine("Odd Numbers:");
    foreach (var oddNumber in oddNumbers)
    {
        Console.WriteLine(oddNumber);
    }

    Console.WriteLine("Even Numbers:");
    foreach (var evenNumber in evenNumbers)
    {
        Console.WriteLine(evenNumber);
    }
}