//int n = int.Parse(Console.ReadLine());

//int temporaryNumber = n;

//for (int i = 0; i < n; i++)
//{
//    int newNumber = int.Parse(Console.ReadLine());

//    if (newNumber % 2 == 0)
//    {
//        Console.WriteLine($"{newNumber} is special");
//    }

//    if (newNumber % 2 == 1)
//    {
//        Console.WriteLine($"{newNumber} is not special");
//    }
//}


using System.Security.Cryptography;

int n = int.Parse(Console.ReadLine());

int tempNumber = n;

bool isSpecialNumber = true;

while (tempNumber > 0)
{
    int currentLastDigit = tempNumber % 10;
    tempNumber = tempNumber / 10;

    if (n % currentLastDigit != 0)
    {
        isSpecialNumber = false;
        break;
    }
}
if (isSpecialNumber)
{
    Console.WriteLine($"{n} is special");
}
else
{
    Console.WriteLine($"{n} is not special");
}
