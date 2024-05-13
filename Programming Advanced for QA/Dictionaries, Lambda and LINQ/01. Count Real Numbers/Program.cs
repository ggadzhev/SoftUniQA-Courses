using System.Diagnostics.Metrics;

List<double> digits = Console.ReadLine()
                     .Split()
                     .Select(double.Parse)
                     .ToList();

SortedDictionary<double, int> dictionary = new SortedDictionary<double, int>();

foreach (var number in digits)
{
    
    if (dictionary.ContainsKey(number))
    {
        dictionary[number]++;
    }
    else
    {
        dictionary.Add(number, 1);
        //keyValuePairs[number] = 1;
    }
}

foreach (KeyValuePair<double, int> element in dictionary)
{
    Console.WriteLine($"{element.Key} -> {element.Value}");
}

