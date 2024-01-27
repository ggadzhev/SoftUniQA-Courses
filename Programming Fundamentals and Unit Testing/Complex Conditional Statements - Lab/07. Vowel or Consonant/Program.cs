char letter = char.Parse(Console.ReadLine());

switch (letter)
{
	case 'A':
	case 'a':
	case 'E':
	case 'e':
	case 'I':
	case 'i':
	case 'O':
	case 'o':
	case 'U':
	case 'u':
        Console.WriteLine("Vowel");
		break;


    default:
        Console.WriteLine("Consonant");
        break;
}