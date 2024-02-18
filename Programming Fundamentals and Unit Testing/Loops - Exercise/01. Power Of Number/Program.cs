int number = int.Parse(Console.ReadLine());
int power = int.Parse(Console.ReadLine());

int sum  = 1;

for (int i = 0; i < power; i++)
{
    sum *= number;
}
Console.WriteLine(sum);
