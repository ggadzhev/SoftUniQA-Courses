int chickenMenu = int.Parse(Console.ReadLine());
int fishMenu = int.Parse(Console.ReadLine());
int vegetarianMenu = int.Parse(Console.ReadLine());

double orderPrice = (chickenMenu * 10.35) + (fishMenu * 12.40) + (vegetarianMenu * 8.15);
double desertPrice = orderPrice - (orderPrice * 0.20);

double totalPrice = orderPrice + desertPrice + 2.50;

Console.WriteLine(totalPrice);