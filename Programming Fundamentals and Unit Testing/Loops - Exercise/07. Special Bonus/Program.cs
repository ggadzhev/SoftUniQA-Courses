int stopNumber = int.Parse(Console.ReadLine());

int previousNumber = 0;
int currentNumber;

while (true)
{
    
    currentNumber = int.Parse(Console.ReadLine());

    if (currentNumber == stopNumber)
    {
        break;
    }

    previousNumber = currentNumber;
}

double bonusValue = previousNumber * 0.2;
double bonusResult = previousNumber + bonusValue;

Console.WriteLine(bonusResult);