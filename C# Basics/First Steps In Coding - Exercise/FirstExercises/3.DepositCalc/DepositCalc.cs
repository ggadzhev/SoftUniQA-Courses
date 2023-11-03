using System.Diagnostics.CodeAnalysis;
//Input
double depositedAmount = double.Parse(Console.ReadLine());
int depositPeriod = int.Parse(Console.ReadLine());
double yearlyInterest  = double.Parse(Console.ReadLine()) / 100;


//Calcs

double oneYearInterest = depositedAmount * yearlyInterest;

double oneMonthInterest = oneYearInterest / 12;

double totalSum = depositedAmount + oneMonthInterest * depositPeriod;

//Output
Console.WriteLine(totalSum);