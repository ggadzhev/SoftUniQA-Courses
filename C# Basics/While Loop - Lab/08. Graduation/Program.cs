string name = Console.ReadLine();

double totalGrade  = 0;

int year = 1;
int classFails = 0;

while (true)
{
    double grade = double.Parse(Console.ReadLine());
    if (grade < 4.00)
    {
        if (classFails == 1)
        {
            Console.WriteLine($"{name} has been excluded at {year} grade");
            break;
        }
        classFails++;
    }
    else
    {
        totalGrade += grade;
        year++;
    }
    if (totalGrade > 12)
    {
        Console.WriteLine($"{name} graduated. Average grade: {(totalGrade / 12):F2}");
        break;
    }
}
