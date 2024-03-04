int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
int startIndex = int.Parse(Console.ReadLine());
int endIndex = int.Parse(Console.ReadLine());


int sum = FindMinMaxAndSum(inputArray, startIndex, endIndex);

static int FindMinMaxAndSum(int[] arr, int start, int end)
{

    start = Math.Max(0, Math.Min(start, arr.Length - 1));
    end = Math.Max(start, Math.Min(end, arr.Length - 1));


    int minNum = arr.Skip(start).Take(end - start + 1).Min();
    int maxNum = arr.Skip(start).Take(end - start + 1).Max();


    int resultSum = minNum + maxNum;

    return resultSum;
}

Console.WriteLine(sum);