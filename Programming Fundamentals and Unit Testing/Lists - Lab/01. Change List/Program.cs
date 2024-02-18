// operations - add / insert / remove / find element
// add(element) - adds an element into the List<T>
// count - number of elements within the List<T>
// remove(element) - removing element from the List

// insert(index, element) - inserts element to a given index
// contains(element) - determines whether an element is in the list
// sort() - sorts the array/list in ascending order (smallest to largest)
// reverse() - sorts from back
// List<int> items = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

//List<string> names = new List<string>()
//{
//    "Peter", "Michael", "George", "Victor", "John"

//};
//names.Sort();
//Console.WriteLine(string.Join(", ", names));

//names.Reverse();
//Console.WriteLine(string.Join(", ", names));
// List<int> numbers = Console.ReadLine()
//    .Split()
//    .Select(int.Parse)
//    .ToList();
List<int> numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

string command = Console.ReadLine();

while (command != "end")
{
    string[] commandElements = command.Split().ToArray();
    if (commandElements[0] == "Delete")
    {
        int number = int.Parse(commandElements[1]);
        while (numbers.Contains(number))
        {
            numbers.Remove(number);
        }

    }
    else if (commandElements[0] == "Insert")
    {
        int number = int.Parse(commandElements[1]);
        int position = int.Parse(commandElements[2]);
        
        numbers.Insert(position, number);
    }
    command = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", numbers));
