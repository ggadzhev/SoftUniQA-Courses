double depositedAmount = double.Parse(Console.ReadLine());
int termMonths = int.Parse(Console.ReadLine());
double annualInterestRate = double.Parse(Console.ReadLine()) / 100;

double amount;
amount = depositedAmount + termMonths * (depositedAmount * annualInterestRate) / 12;


Console.WriteLine(amount);
