using EncapsulationBankingApp;

var account = new BankAccount();

Console.WriteLine("Welcome to Bowman Banking App!");
Console.WriteLine("=====================================");

while (true)
{
    Console.WriteLine("\nPlease select an option:");
    Console.WriteLine("1. Deposit money");
    Console.WriteLine("2. Check balance");
    Console.WriteLine("3. Exit");

    int option;
    if (!int.TryParse(Console.ReadLine(), out option))
    {
        Console.WriteLine("Invalid input. Please enter a valid option.");
        continue;
    }

    switch (option)
    {
        case 1:
            Console.Write("Enter the amount to deposit: ");
            double amount;
            if (!double.TryParse(Console.ReadLine(), out amount))
            {
                Console.WriteLine("Invalid input. Please enter a valid amount.");
                continue;
            }

            account.Deposit(amount);
            Console.WriteLine("Deposit successful!");
            break;

        case 2:
            Console.WriteLine($"Current balance: {account.GetBalance()}");
            break;

        case 3:
            Console.WriteLine("Thank you for using Bowman Banking App. Goodbye!");
            return;

        default:
            Console.WriteLine("Invalid option. Please select a valid option.");
            break;
    }
}