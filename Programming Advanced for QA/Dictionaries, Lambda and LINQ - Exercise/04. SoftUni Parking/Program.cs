int totalCommands = int.Parse(Console.ReadLine());


var userPlateDictionary = new Dictionary<string, string>();

for (int i = 0; i < totalCommands; i++)
{
    string[] commandParametersArray = Console.ReadLine().Split();
    string commandType = commandParametersArray[0];
    string userID = commandParametersArray[1];
    

    if (commandType == "register")
    {
        string plateID = commandParametersArray[2];

        if (!userPlateDictionary.ContainsKey(userID))
        {
            userPlateDictionary.Add(userID, plateID);
            Console.WriteLine($"{userID} registered {plateID} successfully");
        }
        else
        {
            Console.WriteLine($"ERROR: already registered with plate number {userPlateDictionary[userID]}");
        }
    }
    else if (commandType == "unregister")
    {
        if (userPlateDictionary.ContainsKey(userID))
        {
            userPlateDictionary.Remove(userID);
            Console.WriteLine($"{userID} unregistered successfully");
        }
        else
        {
            Console.WriteLine($"ERROR: user {userID} not found");
        }
    }

}

foreach (var pairs in userPlateDictionary)
{
    Console.WriteLine($"{pairs.Key} => {pairs.Value} ");
}