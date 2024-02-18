int n = int.Parse(Console.ReadLine());

int maxNumber = int.MinValue;


for (int i = 1; i <= n; i++)
{
    int newNumber = int.Parse(Console.ReadLine());
   
    if (newNumber > maxNumber)
    {
        maxNumber = newNumber;
    }
}
Console.WriteLine(maxNumber);