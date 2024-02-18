
        double balance = 0;
        string transactionsOutput = "";

        while (true)
        {
            string input = Console.ReadLine();

            if (input == "End")
            {
                break;
            }

            double amount;
            if (double.TryParse(input, out amount))
            {
                if (amount >= 0)
                {
                    transactionsOutput += $"Increase: {amount:F2}\n";
                }
                else
                {
                    transactionsOutput += $"Decrease: {Math.Abs(amount):F2}\n";
                }

                balance += amount;
            }
            
        }

        Console.WriteLine(transactionsOutput + $"Balance: {balance:F2}");
