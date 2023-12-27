int number = int.Parse(Console.ReadLine());

for (int n = 0; n <= number; n += 2)
{
    Console.WriteLine(Math.Pow(2, n));
}
