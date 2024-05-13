string resource = Console.ReadLine();


Dictionary<string, double> resourceDictionary = new Dictionary<string, double>();   

while (resource != "stop")
{
    double quantity = double.Parse(Console.ReadLine());

    if (resourceDictionary.ContainsKey(resource))
    {
        resourceDictionary[resource] += quantity;
    }
    else
    {
        resourceDictionary.Add(resource, quantity);
    }

    resource = Console.ReadLine();

}

foreach (var pair in resourceDictionary)
{
    Console.WriteLine($"{pair.Key} -> {pair.Value}");
}
