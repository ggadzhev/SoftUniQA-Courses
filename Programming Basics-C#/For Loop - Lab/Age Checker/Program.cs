
Console.WriteLine("Enter your age:");
double age = double.Parse(Console.ReadLine());

if (age >= 0 && age < 13)
{
    Console.WriteLine("Child");
}
else if (age >= 13 && age < 20)
{
    Console.WriteLine("teenager");
}
else if (age >= 20 && age < 65)
{
    Console.WriteLine("adult");
}
else if (age >= 65 && age <= 150)
{
    Console.WriteLine("elder");
}
else
{
    Console.WriteLine("error");
}

