﻿//input

int points = int.Parse(Console.ReadLine());

//calculations

double bonus = 0.0;

if (points <= 100)
{
    bonus = 5;
}
else if(points > 1000)
{
    bonus = points * 0.1;
}
else 
{
    bonus = points * 0.2;
}
if (points % 2 == 0)
{
    bonus = bonus + 1;
}
else if (points % 10 == 5)
{
    bonus += 2;
}



Console.WriteLine(bonus);
Console.WriteLine(points + bonus);