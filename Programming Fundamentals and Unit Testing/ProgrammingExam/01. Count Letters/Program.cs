string upperLowerCaseString = Console.ReadLine();

int uppperLettersCount = 0;
int lowerLettersCount = 0;
int oneSpaceInWordsCount = 0;


foreach (char chars in upperLowerCaseString)
{
    if (char.IsUpper(chars))
        uppperLettersCount++;
    else if (char.IsLower(chars))
        lowerLettersCount++;
    else if (char.IsWhiteSpace(chars))
        oneSpaceInWordsCount++;
}

Console.WriteLine(uppperLettersCount);
Console.WriteLine(lowerLettersCount);
Console.WriteLine(oneSpaceInWordsCount);