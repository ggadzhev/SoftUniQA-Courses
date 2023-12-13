int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
char operation = char.Parse(Console.ReadLine());


switch (operation)
{
    case '+':
        int sum = n1 + n2;
        Console.WriteLine($"{n1} + {n2} = {sum} - {(sum % 2 == 0 ? "even" : "odd")}");
        break;
    case '-':
        int diff = n1 - n2;
        Console.WriteLine($"{n1} - {n2} = {diff} - {(diff % 2 == 0 ? "even" : "odd")}");
        break;
    case '*':
        int multiply = n1 * n2;
        Console.WriteLine($"{n1} * {n2} = {multiply} - {(multiply % 2 == 0 ? "even" : "odd")}");
        break;
    case '/':
        if (n2 != 0)
        {
            double divide = (double)n1 / n2;
            Console.WriteLine($"{n1} / {n2} = {divide:F2}");
        }
        else if (n2 == 0)
        {
            Console.WriteLine($"Cannot divide {n1} by zero");
        }
        break;
    case '%':
        if (n2 != 0)
        {
            int divideModule = n1 % n2;
            Console.WriteLine($"{n1} % {n2} = {divideModule}");
        }
        else if (n2 == 0)
        {
            Console.WriteLine($"Cannot divide {n1} by zero");
        }
        break;
}













