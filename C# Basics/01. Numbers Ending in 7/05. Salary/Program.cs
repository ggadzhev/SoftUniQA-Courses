int webTabs = int.Parse(Console.ReadLine());
int salary = int.Parse(Console.ReadLine());

//int salaryDeduct = 0;

for (int i = 0; i < webTabs; i++)
{
    string webName = Console.ReadLine();
    if (webName == "Facebook")
    {
        salary -= 150;
    }
    else if (webName == "Instagram")
    {
        salary -= 100;
    }
    else if (webName == "Reddit")
    {
        salary -= 100;
    }
    if (salary <= 0)
    {
        Console.WriteLine("You have lost your salary.");
        break;
    }
   

}
if (salary > 0)
{
    Console.WriteLine(salary);
}
