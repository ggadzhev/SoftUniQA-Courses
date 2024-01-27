int one = int.Parse(Console.ReadLine());
int two = int.Parse(Console.ReadLine());
int three = int.Parse(Console.ReadLine());
int four = int.Parse(Console.ReadLine());
int five = int.Parse(Console.ReadLine());

if (one > two && one > three && one > four && one > five)
{
    Console.WriteLine(one);
}
else if (two > one && two > three && two > four && two > five)
{
    Console.WriteLine(two);
}
else if (three > one && three > two && three > four && three > five)
{
    Console.WriteLine(three);
}
else if (four > one && four > two && four > three && four > five)
{
    Console.WriteLine(four);
}
else if (five > one && five > two && five > three && five > four)
{
    Console.WriteLine(five);
}
