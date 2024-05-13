string productsInput = Console.ReadLine();


var productsDictionary = new Dictionary<string, List<double>>();

while (productsInput != "buy")
{
    string[] productsArray = productsInput.Split();

    string productItem = productsArray[0];
    double productPrice = double.Parse(productsArray[1]);
    double productQuantity = double.Parse(productsArray[2]);

    if (!productsDictionary.ContainsKey(productItem))
    {
        productsDictionary.Add(productItem, new List<double>());

        productsDictionary[productItem].Add(productPrice);
        productsDictionary[productItem].Add(productQuantity);

    }
    else
    {
        productsDictionary[productItem][0] = productPrice;
        productsDictionary[productItem][1] += productQuantity;
    }
  
    productsInput = Console.ReadLine();

}

foreach (var pairs in productsDictionary)
{
    string product = pairs.Key;
    double price = pairs.Value[0];
    double quantity = pairs.Value[1];
    double amount = price * quantity;

    Console.WriteLine($"{product} -> {amount:F2}");
}
