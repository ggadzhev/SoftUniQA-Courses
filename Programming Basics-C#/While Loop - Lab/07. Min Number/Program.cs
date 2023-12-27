string number = Console.ReadLine();

int minNumber = int.MaxValue;


while (number != "Stop")
{
    int numb = int.Parse(number);
    if (numb < minNumber)
    {
        minNumber = numb;
    }



    number = Console.ReadLine();

}

Console.WriteLine(minNumber);