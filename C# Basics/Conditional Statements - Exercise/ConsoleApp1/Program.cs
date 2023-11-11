double poolVolumeLitersV = double.Parse(Console.ReadLine());
double flowFirstPipeForHourP1 = double.Parse(Console.ReadLine());
double flowSecondPipeForHourP2 = double.Parse(Console.ReadLine());
double WorkerIsAbsentH = double.Parse(Console.ReadLine());

double waterFromP1Liters = flowFirstPipeForHourP1 * WorkerIsAbsentH;
double waterFromP2Liters = flowSecondPipeForHourP2 * WorkerIsAbsentH;
double totalP1P2Liters = waterFromP1Liters + waterFromP2Liters;

if (totalP1P2Liters <= poolVolumeLitersV)
{
    double percentP1P2Volume = (totalP1P2Liters / poolVolumeLitersV) * 100;
    double percentP1Volume = (waterFromP1Liters / totalP1P2Liters) * 100;
    double percentP2Volume = (waterFromP2Liters / totalP1P2Liters) * 100;
    Console.WriteLine($"The pool is {percentP1P2Volume:f2}% full. Pipe 1: {percentP1Volume:f2}%. Pipe 2: {percentP2Volume:f2}%.");
}

else if (totalP1P2Liters > poolVolumeLitersV)
{
    double waterOverflow = totalP1P2Liters - poolVolumeLitersV;
    Console.WriteLine($"For {WorkerIsAbsentH:f2} hours the pool overflows with {waterOverflow:f2} liters.");
}