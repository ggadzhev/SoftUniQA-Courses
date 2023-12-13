int number = int.Parse(Console.ReadLine());

int sum = 0;


while (true)
{
    int input = int.Parse(Console.ReadLine());
    sum += input;

    if (sum >= number)
    {
        Console.WriteLine(sum);
        break;
    }
}
