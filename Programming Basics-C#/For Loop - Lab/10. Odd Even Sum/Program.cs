int n = int.Parse(Console.ReadLine());

int evenNumbers = 0;
int oddNumbers = 0;

for (int i = 1; i <= n; i++)
{
    int number = int.Parse(Console.ReadLine());
    if (i % 2 == 0)
    {
        evenNumbers += number;
    }
    else
    {
        oddNumbers += number;
        
    }
    

}

int difference = Math.Abs(evenNumbers - oddNumbers);

if (evenNumbers == oddNumbers)
{
    Console.WriteLine("Yes");
    Console.WriteLine($"Sum = {evenNumbers}");
}
else
{
    Console.WriteLine("No");
    Console.WriteLine($"Diff = {difference}");
}
