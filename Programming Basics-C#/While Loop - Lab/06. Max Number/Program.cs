string number = Console.ReadLine();

int maxNumber = int.MinValue;


while (number != "Stop")
{
    int numb = int.Parse(number);
    if (numb > maxNumber)
    {
        maxNumber = numb;
    }

    
    
    number = Console.ReadLine();

}

Console.WriteLine(maxNumber);