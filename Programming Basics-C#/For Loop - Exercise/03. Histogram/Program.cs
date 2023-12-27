int numbersTotal = int.Parse(Console.ReadLine());


int p1 = 0, p2 = 0, p3 = 0, p4 = 0, p5 = 0;

for (int i = 0; i < numbersTotal; i++)
{
    int number = int.Parse(Console.ReadLine());

    if (number < 200)
    {
        p1++;
    }
    else if (number < 400)
    {
        p2++;
    }
    else if (number < 600)
    {
        p3++;
    }
    else if (number < 800)
    {
        p4++;
    }
    else
    {
        p5++;
    }
}

Console.WriteLine($"{(double)p1 / numbersTotal * 100.0:F2}%");
Console.WriteLine($"{(double)p2 / numbersTotal * 100.0:F2}%");
Console.WriteLine($"{(double)p3 / numbersTotal * 100.0:F2}%");
Console.WriteLine($"{(double)p4 / numbersTotal * 100.0:F2}%");
Console.WriteLine($"{(double)p5 / numbersTotal * 100.0:F2}%");


