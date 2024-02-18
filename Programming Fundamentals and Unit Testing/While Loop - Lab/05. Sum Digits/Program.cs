int n = int.Parse(Console.ReadLine());

int sum = 0;

while (n > 0)
{
    int digit = n % 10;
    n = n / 10;
    sum += digit;
   
}
Console.WriteLine(sum);


// ex n = 3451
// 3451 % 10 = 1
// 3451 / 10 = 345
// 345 % 10 = 5
// 345 / 10 = 34
// 34 % 10 = 4
// 34 / 10 = 3
// 3 / 10 = 0
//3 % 10 = 3