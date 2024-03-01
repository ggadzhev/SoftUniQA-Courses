
int maxFirst = int.Parse(Console.ReadLine()); 
int maxSecond = int.Parse(Console.ReadLine()); 
int maxThird = int.Parse(Console.ReadLine()); 


for (int firstDigit = 2; firstDigit <= maxFirst; firstDigit += 2) 
{
    for (int secondDigit = 1; secondDigit <= maxSecond; secondDigit++) 
    {
        for (int thirdDigit = 2; thirdDigit <= maxThird; thirdDigit += 2) 
        {
           
            if (secondDigit == 2 || secondDigit == 3 || secondDigit == 5 || secondDigit == 7)
            {
                
                Console.WriteLine($"{firstDigit}{secondDigit}{thirdDigit}");

            }
        }
    }
}