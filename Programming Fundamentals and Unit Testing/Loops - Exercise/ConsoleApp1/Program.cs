Console.WriteLine("Please, enter your password.");
string passWord = "";

while (passWord != "myPass")
{
    passWord = Console.ReadLine();
    Console.WriteLine("Wrong Pass");
    Console.WriteLine("Please enter new password");
}
Console.WriteLine("Welcome");