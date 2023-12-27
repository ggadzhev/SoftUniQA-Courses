//input

double excursionPrice = double.Parse(Console.ReadLine());  
int puzzles = int.Parse(Console.ReadLine());               
int talkingDolls = int.Parse(Console.ReadLine());          
int fluffyBears = int.Parse(Console.ReadLine());           
int minions = int.Parse(Console.ReadLine());              
int toyTruck = int.Parse(Console.ReadLine());             

double puzzlePrice = puzzles * 2.60;
double dollsPrice = talkingDolls * 3.00;
double bearsPrice = fluffyBears * 4.10;
double minionsPrice = minions * 8.20;
double trucksPrice = toyTruck * 2.00;

// if toys are more than 50 you get 25% discount. 10% of earnings need to go for rent.

double sumToys = puzzlePrice + dollsPrice + bearsPrice + minionsPrice + trucksPrice;
double totalToysCount = puzzles + talkingDolls + fluffyBears + minions + toyTruck;


if (totalToysCount >= 50)
{
    double discountPrice = sumToys * 0.25;
    double totalPriceDiscount = sumToys - discountPrice;
    double rent = totalPriceDiscount * 0.10;
    double earnings = totalPriceDiscount - rent;
    double remainingLeva = earnings - excursionPrice;

    Console.WriteLine($"Yes! {remainingLeva:F2} lv left.");
}
else if (totalToysCount <= 50)
{
    double rent = sumToys * 0.10;
    double earnings = sumToys - rent;
    double insufficientMoney = excursionPrice - earnings;

    Console.WriteLine($"Not enough money! {insufficientMoney:F2} lv needed.");
}






//  Console.WriteLine(totalPriceDiscount);
//Console.WriteLine(totalToysCount);

