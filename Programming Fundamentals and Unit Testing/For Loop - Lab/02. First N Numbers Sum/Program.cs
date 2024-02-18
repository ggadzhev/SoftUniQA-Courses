int number = int.Parse(Console.ReadLine());

int sum = 0;

for (int i = 1; i <= number; i++)
{
    sum+=i;
   
}
for (int i = 1; i < number; i++)
{
    Console.Write($"{i}+");
}
Console.Write(number);
Console.WriteLine($"={sum}");