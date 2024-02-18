int size = int.Parse(Console.ReadLine());

int[] numbers = new int[size];

for (int i = 0; i < numbers.Length; i++)   // numbers.lenght == size
{
    numbers[i] = int.Parse(Console.ReadLine());
}

for (int i = numbers.Length - 1; i >= 0; i--)
{
    Console.Write($"{numbers[i]} ");
}
