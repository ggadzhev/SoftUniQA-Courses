double bathWidth = double.Parse(Console.ReadLine());
double bathHeigth = double.Parse(Console.ReadLine());
double tileWidth = double.Parse(Console.ReadLine());
double tileHeigth = double.Parse(Console.ReadLine());

double bathroomArea = bathWidth * bathHeigth;
double bathroomAreaWithSurplus = bathroomArea + (bathroomArea * 0.10);
double tileArea = tileWidth * tileHeigth;
double tilesNeeded = bathroomAreaWithSurplus / tileArea;

Console.WriteLine(Math.Round(tilesNeeded));