// input

double neededAmountOfNylon = int.Parse(Console.ReadLine());
double neededAmountOfPaint = int.Parse(Console.ReadLine());
double amountOfThinner = int.Parse(Console.ReadLine());
double totalHours = int.Parse(Console.ReadLine());

//calcs

double NylonSum = (neededAmountOfNylon + 2) * 1.50;  // сума за найлон
double additionalPaint = neededAmountOfPaint * 0.10; // 10% допълнително боя 
double paintSum = (neededAmountOfPaint + additionalPaint) * 14.50; //сума за боя (+10% допълнително боля)
double thinnerSum = amountOfThinner * 5; // сума за разредител
double bagPrice = 0.40; // сума за торбичка
double allProductsPrice = NylonSum + paintSum + thinnerSum + bagPrice; // обща сума материали
double sumForWorkers = (allProductsPrice * 0.30) * totalHours; // общо време за работници
double totalSum = allProductsPrice + sumForWorkers;  // крайна сума 




//output
Console.WriteLine(totalSum.ToString("F2"));


