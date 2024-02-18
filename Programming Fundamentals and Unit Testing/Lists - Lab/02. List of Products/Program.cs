int n = int.Parse(Console.ReadLine());            // number of products

List<string> products = new List<string>();

for (int i = 0; i < n; i++)
{
    string product = Console.ReadLine();          // string[] productsArray = new string[n];
    products.Add(product);                        // add product (string)
}

products.Sort();                                  // sort products by letters

for (int i = 0; i < products.Count; i++)
{
    Console.WriteLine($"{i + 1}.{products[i]}");          //output products + position number
}
