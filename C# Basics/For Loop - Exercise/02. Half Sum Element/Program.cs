int n = int.Parse(Console.ReadLine());




int sum = 0;
int maxNumber = int.MinValue;

for (int i = 0; i < n; i++)
{
    int number = int.Parse(Console.ReadLine());
    sum += number;

   if (number > maxNumber)
    {
        maxNumber = number;
    }

}
int sumWOMaxNumber = sum - maxNumber;
if (maxNumber == sumWOMaxNumber)
{
    Console.WriteLine("Yes");
    Console.WriteLine("Sum = " + maxNumber);
}
else
{
    int diff = Math.Abs(maxNumber - sumWOMaxNumber);
    Console.WriteLine("No");
    Console.WriteLine("Diff = " + diff);
}
