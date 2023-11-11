//input

double mackerelPerKilo = double.Parse(Console.ReadLine());  // цена скумрия/кг  
double spratPerKilo = double.Parse(Console.ReadLine());   // цена цаца/кг
double bonitoKilos = double.Parse(Console.ReadLine());  //  кг паламуд
double scadKilos = double.Parse(Console.ReadLine());   // кг сафрид
int musselsKilos = int.Parse(Console.ReadLine());    // кг миди

// calculations

double bonitoPricePerKilo = mackerelPerKilo + (mackerelPerKilo * 0.60);  // цена на паламуда/kg
double bonitoTotalPrice = bonitoKilos * bonitoPricePerKilo;    // сума паламуд общо
double scadPricePerKilo = spratPerKilo + (spratPerKilo * 0.80);  // цена сафрид/кг
double scadPriceTotal = scadKilos * scadPricePerKilo;   // сума сафрид общо
double musselPriceTotal = musselsKilos * 7.50;  //сума миди общо
double totalPriceAll = bonitoTotalPrice + scadPriceTotal + musselPriceTotal;  // сметка 

//output 
Console.WriteLine($"{totalPriceAll:F2}");
