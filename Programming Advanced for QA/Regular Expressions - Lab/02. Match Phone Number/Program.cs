using System.Text.RegularExpressions;

string phoneNumber = Console.ReadLine();

string pattern = @"\+359([\ \-])2\1\d{3}\1\d{4}\b";
Regex regex = new Regex(pattern);

MatchCollection matches = regex.Matches(phoneNumber);

List<string> result = new List<string>();


foreach (Match match in matches)
{
    result.Add(match.Value);
}

Console.WriteLine(string.Join(", ", result));

