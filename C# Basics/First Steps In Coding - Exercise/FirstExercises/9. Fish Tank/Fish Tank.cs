/// input


Console.WriteLine("Дължина см.");
int lenghtSm = int.Parse(Console.ReadLine());
Console.WriteLine("Широчина см");
int widthSm = int.Parse(Console.ReadLine());
Console.WriteLine("Височина см");
int heightSm = int.Parse(Console.ReadLine());
Console.WriteLine("Процент");
double percentage = double.Parse(Console.ReadLine());


//calcs

double aquariumSize = lenghtSm * widthSm * heightSm;
double litersAmount = aquariumSize * 0.001;
double requiredLiters = litersAmount * (1 - percentage / 100.0);

// output

Console.WriteLine("Литри вода които ще събира аквариума");
Console.WriteLine(requiredLiters.ToString("F2"));
