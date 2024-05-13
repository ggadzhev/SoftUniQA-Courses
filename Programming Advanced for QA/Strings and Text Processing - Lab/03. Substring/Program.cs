string word = Console.ReadLine();  // word to be removed from text
string text = Console.ReadLine();   // whole text containing a word which will be removed

while (text.Contains(word))
{
    int wordIndex = text.IndexOf(word);

    string beforeWord = text.Substring(0, wordIndex);
    string afterWord = text.Substring(wordIndex + word.Length);

    text = beforeWord + afterWord;

}
Console.WriteLine(text);