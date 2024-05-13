string input = Console.ReadLine();

while (input != "end")
{
    char[] output = input.ToCharArray().Reverse().ToArray();
    string reversedString = string.Join("", output);

    Console.WriteLine(input + " = " + reversedString);

    input = Console.ReadLine();

}

