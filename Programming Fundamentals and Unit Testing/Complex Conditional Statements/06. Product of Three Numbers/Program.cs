double num1 = double.Parse(Console.ReadLine());

double num2 = double.Parse(Console.ReadLine());

double num3 = double.Parse(Console.ReadLine());

string sign;

if (num1 == 0 || num2 == 0 || num3 == 0)
{
    sign = "zero";
}
else if ((num1 < 0 && num2 < 0 && num3 > 0) || (num1 < 0 && num2 > 0 && num3 < 0) || (num1 > 0 && num2 < 0 && num3 < 0))
{
    sign = "positive";
}
else
{
    sign = "negative";
}
    Console.WriteLine(sign);