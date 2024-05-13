using System.Text;

string[] input = { "test code code code" };

Console.WriteLine(ReverseAndConcatenateStrings(input));
    static string ReverseAndConcatenateStrings(string[]? inputStrings)
    {
        if (inputStrings == null || inputStrings.Length == 0)
        {
            return string.Empty;
        }

        StringBuilder reversedStrings = new();
        for (int i = inputStrings.Length - 1; i >= 0; i--)
        {
            reversedStrings.Append(inputStrings[i]);
        }

        return reversedStrings.ToString();
    }

