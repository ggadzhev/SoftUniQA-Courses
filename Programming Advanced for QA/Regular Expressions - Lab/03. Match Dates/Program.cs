using System.Text.RegularExpressions;

string phoneNumber = Console.ReadLine();

string pattern = @"\d{2}(?'del'[\/\.\-])[A-Z][a-z]{2}\'del'\d{4}\b";
Regex regex = new Regex(pattern);

MatchCollection matches = regex.Matches(phoneNumber);




foreach (Match match in matches)
{
    string.
}



