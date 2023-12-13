int age = int.Parse(Console.ReadLine());
double cleaningMachinePrice = double.Parse(Console.ReadLine());   
int toyPrice = int.Parse(Console.ReadLine());

int totalMoney = 0;
int giftedMoney = 10;

for (int i = 1; i <= age; i++)
{
    if (i % 2 == 0)
    {
        totalMoney += giftedMoney - 1;
        giftedMoney += 10;
    }
    else
    {
        totalMoney += toyPrice;
    }
}

if (totalMoney >= cleaningMachinePrice)
{
    Console.WriteLine($"Yes! {totalMoney - cleaningMachinePrice:F2}");
}
else
{
    Console.WriteLine($"No! {cleaningMachinePrice - totalMoney:F2}");
}
