double processorPrice = double.Parse(Console.ReadLine());  //цена процесор
double gpuPrice  = double.Parse(Console.ReadLine());      // цена видеокарта
double ramPrice = double.Parse(Console.ReadLine());      // цена РАМ
int ramAmount = int.Parse(Console.ReadLine());     //   брой рам
double discountPercentage = double.Parse(Console.ReadLine());   //процент отстъпка

// calculations


processorPrice = processorPrice * 1.57;
gpuPrice = gpuPrice * 1.57;
ramPrice = ramPrice * 1.57;

double totalRamPrice = ramPrice * ramAmount;
double totalCpuPrice = processorPrice - (processorPrice * discountPercentage);
double totalGpuPrice = gpuPrice - (gpuPrice * discountPercentage);
double totalPiecesPrice = totalCpuPrice + totalGpuPrice + totalRamPrice;


Console.WriteLine($"Money needed - {totalPiecesPrice:F2} leva.");
