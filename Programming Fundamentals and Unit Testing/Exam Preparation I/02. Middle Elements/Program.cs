int[] ints = Console.ReadLine().Split().Select(int.Parse).ToArray();

int middle = ints.Length / 2;

int firstNumber = ints[middle - 1]; 
int secondNumber = ints[middle];

double average = (firstNumber + secondNumber) / 2.0;



Console.WriteLine($"{average:F2}");