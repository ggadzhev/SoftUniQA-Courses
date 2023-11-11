using System.ComponentModel.Design;

double age = double.Parse(Console.ReadLine());
string gender = Console.ReadLine();

if (gender == "f")
{
    if (age >= 16)
    {
        Console.WriteLine("Ms.");
    }
    else
    {
        Console.WriteLine("Miss");
    }
}
   
if (gender == "m")
    {
        if (age >= 16)
        {
            Console.WriteLine("Mr.");
        }
        else
        {
            Console.WriteLine("Master");
        }
    }

