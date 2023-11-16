double budget = double.Parse(Console.ReadLine());
int GPUs = int.Parse(Console.ReadLine());
int CPUs = int.Parse(Console.ReadLine());
int RAM  = int.Parse(Console.ReadLine());

double gpuPrice = GPUs * 250;
double cpuPrice = (gpuPrice * 0.35) * CPUs;
double ramPrice = (gpuPrice * 0.10) * RAM;

double totalPriceAll = gpuPrice + cpuPrice + ramPrice;

if (GPUs > CPUs)
{
    totalPriceAll = totalPriceAll - (totalPriceAll * 0.15);
}

if (totalPriceAll <= budget)
{
    Console.WriteLine($"You have {(budget - totalPriceAll):F2} leva left!");
}
else
{
    Console.WriteLine($"Not enough money! You need {(totalPriceAll - budget):F2} leva more!");
}