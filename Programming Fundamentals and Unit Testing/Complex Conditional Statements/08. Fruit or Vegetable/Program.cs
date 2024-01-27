string product = Console.ReadLine();

switch (product)
{
    case "banana":
    case "apple":
    case "kiwi":
    case "cherry":
    case "lemon":
        Console.WriteLine("fruit");
        break;

    case "cucumber":
    case "carrot":
    case "pepper":
        Console.WriteLine("vegetable");
        break;

    default:
        Console.WriteLine("unknown");
        break;
}