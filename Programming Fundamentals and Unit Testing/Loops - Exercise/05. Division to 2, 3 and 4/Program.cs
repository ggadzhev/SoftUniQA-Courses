int n = int.Parse(Console.ReadLine());

int numbersDividedByModule2 = 0;
int numbersDividedByModule3 = 0;
int numbersDividedByModule4 = 0;



for (int i = 0; i < n; i++)
{
    int newNumber = int.Parse(Console.ReadLine());
    
    if (newNumber % 2 == 0)
    {
        numbersDividedByModule2++;
    }
    if (newNumber % 3 == 0)
    {
        numbersDividedByModule3++;
    }
    if (newNumber % 4 == 0)
    {
        numbersDividedByModule4++;
    }

}

double numbersDividedByMod2 = (double)numbersDividedByModule2 / n * 100;
double numbersDividedByMod3 = (double)numbersDividedByModule3 / n * 100;
double numbersDividedByMod4 = (double)numbersDividedByModule4 / n * 100;

Console.WriteLine($"{numbersDividedByMod2:F2}%");
Console.WriteLine($"{numbersDividedByMod3:F2}%");
Console.WriteLine($"{numbersDividedByMod4:F2}%");
