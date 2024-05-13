List<string> stringArray = Console.ReadLine()
                     .Split()
                     .Where(s => s.Length % 2 == 0)
                     .ToList();


foreach (string str in stringArray)
{
    Console.WriteLine(str);
}
