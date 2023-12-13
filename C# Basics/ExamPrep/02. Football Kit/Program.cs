//цената на шортите е 75% от цената на тениските
// цената на чорапите е 20% от цената на шортите
//  Бутонките струват два пъти колкото тениската и шортите взети заедно.
//карта за отстъпка на стойност 15% от общата сума на покупката. 

double tshirtPrice = double.Parse(Console.ReadLine());
double requiredSumForReward = double.Parse(Console.ReadLine());

double shortsPrice = tshirtPrice * 0.75;
double socksPrice = shortsPrice * 0.20;
double shoesPrice = (tshirtPrice + shortsPrice) * 2;
double totalSum = tshirtPrice + socksPrice + shoesPrice + shortsPrice;
double totalSumDiscount = totalSum - (totalSum * 0.15);

if (totalSumDiscount >= requiredSumForReward)
{
    Console.WriteLine($"Yes, he will earn the world-cup replica ball!");
    Console.WriteLine($"His sum is {totalSumDiscount:F2} lv.");
}
else
{
    Console.WriteLine("No, he will not earn the world-cup replica ball.");
    Console.WriteLine($"He needs {requiredSumForReward - totalSumDiscount:F2} lv. more.");
}
