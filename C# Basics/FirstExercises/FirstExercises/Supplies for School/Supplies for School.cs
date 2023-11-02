/// пакетчета с химикали, пакетчета с маркери, както и препарат за почистване на дъска. 
/// •	Пакет химикали - 5.80 лв. 
//•	Пакет маркери - 7.20 лв. //
//•	Препарат - 1.20 лв (за литър)

//Вход
//От конзолата се четат 4 числа://
//•	Брой пакети химикали - цяло число в интервала [0...100]
//•	Брой пакети маркери - цяло число в интервала [0...100]
//•	Литри препарат за почистване на дъска - цяло число в интервала [0…50]
//•	Процент намаление - цяло число в интервала [0...100]
//Да се отпечата на конзолата колко пари ще са нужни на Ани, за да си плати сметката//
//пишете програма, която изчислява колко пари ще трябва да събере Ани, за да плати сметката, 
   // като имате предвид следния ценоразпис: //
   //Input
double penPackageNumber = double.Parse(Console.ReadLine());
double markerPackageNumber = double.Parse(Console.ReadLine());
double boardWasher = double.Parse(Console.ReadLine());
double discountPercentage = double.Parse(Console.ReadLine());


//calculations

double penPrice = penPackageNumber * 5.80;
double markerPrice = markerPackageNumber * 7.20;
double boardPrice = boardWasher * 1.20;
double allMaterials = penPrice + markerPrice + boardPrice;
double totalPirce = allMaterials - (allMaterials * (discountPercentage / 100));

//output 
Console.WriteLine($"Ani will need to save {totalPirce.ToString("F1")} to pay the bill.");


