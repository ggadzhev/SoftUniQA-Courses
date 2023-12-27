int n = int.Parse(Console.ReadLine());

int min = int.MaxValue;
int max = int.MinValue;

for (int i = 1; i <= n; i++)
{
    int currentNumber = int.Parse(Console.ReadLine());

    if (currentNumber < min)
    {
        min = currentNumber;
    }
    if (currentNumber > max)
    {
        max = currentNumber;
    }
    
}
Console.WriteLine($"Max number: {max}");
Console.WriteLine($"Min number: {min}");