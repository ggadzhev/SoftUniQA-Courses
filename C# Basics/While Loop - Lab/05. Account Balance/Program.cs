
double money = 0;

string input = Console.ReadLine();

while (input != "NoMoreMoney")
{
    double amount = double.Parse(input);
   

    if (amount < 0)
    {
        Console.WriteLine("Invalid operation!");
        break;
    }

    money += amount;
    Console.WriteLine($"Increase: {amount:F2}");

    input = Console.ReadLine();

}
Console.WriteLine($"Total: {money:F2}");

