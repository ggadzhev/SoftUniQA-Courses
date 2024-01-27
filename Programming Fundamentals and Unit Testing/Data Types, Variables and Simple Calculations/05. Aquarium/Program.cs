/// input



int lenghtSm = int.Parse(Console.ReadLine());

int widthSm = int.Parse(Console.ReadLine());

int heightSm = int.Parse(Console.ReadLine());

double percentage = double.Parse(Console.ReadLine());


//calcs

double aquariumSize = lenghtSm * widthSm * heightSm;
double litersAmount = aquariumSize * 0.001;
double occupiedSpace = percentage / 100;
double requiredLiters = litersAmount * (1 - occupiedSpace);

// output

Console.WriteLine($"{requiredLiters:F2}");