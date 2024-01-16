double depositedAmount = double.Parse(Console.ReadLine());
int interestInMonths = int.Parse(Console.ReadLine());
double annualIntRate = double.Parse(Console.ReadLine());

double accumulatedInterest = depositedAmount * (annualIntRate / 100);
double interestPerMonth = accumulatedInterest / 12;
double totalAmount = depositedAmount + (interestInMonths * interestPerMonth);

Console.WriteLine($"{totalAmount:F2}");