//input
double w = double.Parse(Console.ReadLine()); 
double h = double.Parse(Console.ReadLine());

//ccalc
double wInCm = w * 100;
double hInCm = h * 100;


double deskWidth = 70.0; 
double deskLength = 120.0; 


double corridorWidth = 100.0;
double doorWidth = 160.0; 
double podiumWidth = 160.0; 
double podiumLength = 120.0; 

int rows = (int)((hInCm - corridorWidth) / deskWidth + 20);
int columns = (int)((wInCm - doorWidth - podiumWidth) / deskLength + 60);


int totalDesks = rows * columns;


int availableDesks = totalDesks - 1 - 2;


Console.WriteLine(availableDesks);