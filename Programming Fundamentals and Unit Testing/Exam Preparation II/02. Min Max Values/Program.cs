int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

int n = int.Parse(Console.ReadLine());

int minimumNumber = int.MaxValue;
int maximumNumber = int.MinValue;


for (int i = 0; i < n; i++)
{
    if (numbers[i] > maximumNumber)
    {
        maximumNumber = numbers[i];
    }
    if (numbers[i] < minimumNumber)
    {
        minimumNumber = numbers[i];
    }
}
Console.WriteLine(maximumNumber);
Console.WriteLine(minimumNumber);