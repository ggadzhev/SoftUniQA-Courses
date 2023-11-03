//input

Console.WriteLine("Цена на година");
double yearTaxBasketballTraining = double.Parse(Console.ReadLine());   // цена на година 365

//calcs

double priceBasketballSneakers = yearTaxBasketballTraining - (yearTaxBasketballTraining * 0.40);
double priceBasketballOutfit = priceBasketballSneakers - (priceBasketballSneakers * 0.20);
double priceBasketBall = priceBasketballOutfit * 0.25;
double priceBasketBallAccessories = priceBasketBall * 0.20;
double totalPriceEquipment = yearTaxBasketballTraining + priceBasketballSneakers + priceBasketballOutfit + priceBasketBall + priceBasketBallAccessories;

//output

Console.WriteLine(totalPriceEquipment);