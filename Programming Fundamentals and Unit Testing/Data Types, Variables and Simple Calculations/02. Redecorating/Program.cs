int nylonAmount = int.Parse(Console.ReadLine());
int paintAmount = int.Parse(Console.ReadLine());
int thinnerQuantity = int.Parse(Console.ReadLine());
int hoursNeededForWork = int.Parse(Console.ReadLine());

double nylonPrice = (nylonAmount + 2) * 1.50;
double additionalPaint = paintAmount + (paintAmount * 0.10);
double paintPrice = additionalPaint * 14.50;
double thinnerPrice = thinnerQuantity * 5.00;
double bagPrice = 0.40;

double totalPriceMaterials = nylonPrice + paintPrice + thinnerPrice + bagPrice;
double priceForWork =(totalPriceMaterials * 0.30) * hoursNeededForWork;
double totalPriceAll = totalPriceMaterials + priceForWork;

Console.WriteLine(totalPriceAll);