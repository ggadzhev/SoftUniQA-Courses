int n = int.Parse(Console.ReadLine());

bool inRange = n >= 1 && n <= 100;

while (!inRange)
{
    n = int.Parse(Console.ReadLine());
    inRange = n >= 1 && n <= 100;
}

Console.WriteLine(n);