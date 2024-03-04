
static void StringToChars(string randomWord) //method which takes a word and separates each letter/char in the word
{
    char[] wordChars = randomWord.ToCharArray();

    Console.WriteLine(string.Join(",", wordChars));
}

string randomWord = "tenet";

StringToChars(randomWord);