int penPackages = int.Parse(Console.ReadLine());
int markerPackets = int.Parse(Console.ReadLine());
int boardCleanerLiters = int.Parse(Console.ReadLine());
int discountPercentage = int.Parse(Console.ReadLine());

double pricePen = penPackages * 5.80;
double priceMarker = markerPackets * 7.20;
double boardCleanerPrice = boardCleanerLiters * 1.20;
double priceAllMaterials = pricePen + priceMarker + boardCleanerPrice;
double discountedPrice = priceAllMaterials - (priceAllMaterials * 0.25);

Console.WriteLine(discountedPrice);

