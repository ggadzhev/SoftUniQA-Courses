int amountChickenMenus = int.Parse(Console.ReadLine()); // пилешко меню
int amountFishMenus = int.Parse(Console.ReadLine()); // меню с риба
int veganMenus = int.Parse(Console.ReadLine());  // меню веган

//calcs

double sumChickenMenu = amountChickenMenus * 10.35;  // цена пилешки менюта
double sumFishMenu = amountFishMenus * 12.40;  // цена менюта с риба
double sumVeganMenus = veganMenus * 8.15;  // цена веган менюта
double totalMenusSum = sumChickenMenu + sumFishMenu + sumVeganMenus;  // обща цена менюта
double desertPrice = totalMenusSum * 0.20; // цена десерт (20% от обща цена)
double totalOrderSum = totalMenusSum + desertPrice + 2.50;  //


//output

Console.WriteLine(totalOrderSum);