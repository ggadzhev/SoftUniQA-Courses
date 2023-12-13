string text = Console.ReadLine();

int n = text.Length;   // дължина на текст e.g SoftUni = 7   int n = 7

for (int i = 0; i < n; i++)        // int i = 0, when i < n (7) , add + 1 to i
{
    char c = text[i];             // convert index number of the letter into a letter 
    Console.WriteLine(c);
}
