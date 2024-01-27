double numberOne = double.Parse(Console.ReadLine());
double numberTwo = double.Parse(Console.ReadLine());
string typeOperator = Console.ReadLine();

double result = 0;

switch (typeOperator)
{
    case "+":
       result = numberOne + numberTwo;
        break;
    case "-":
        result = numberTwo - numberOne;
        break;
    case "*":
        result = numberOne * numberTwo;
        break;
    case "/":
        result = numberOne / numberTwo;
        break;
}
Console.WriteLine($"{numberOne} {typeOperator} {numberTwo} = {Math.Abs(result):F2}");