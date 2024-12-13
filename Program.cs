namespace OOP_HW1;

internal static class Program
{
    private static void Main()
    {
        Ex2();
    }

    private static void Ex1()
    {
        Employee employee1 = new Employee("John Doe", 50000, "IT");
        Console.WriteLine(employee1);

        Employee employee2 = new Employee("Jane Smith", 60000, "HR");
        Console.WriteLine(employee2);

        employee1.Department = "new Department";
        Console.WriteLine(employee1);
    }


    private static void Ex2()
    {
        Person person = new IndividualPerson("John Doe", "123 Main St", 12345, 1231231231231);
        BankAccount account = new BankAccount(person, MoneyType.Euro, 1234567890, 1234);

        try
        {
            account.Deposit(1000);
        }
        catch (Exception e)
        {
            ShowError(e.Message);
        }

        Console.WriteLine($"Current balance: {account.Balance}");


        try
        {
            account.Withdraw(500);
            account.Withdraw(500);
            account.Withdraw(500);
            account.Withdraw(500);
        }
        catch (ArgumentException e)
        {
            ShowError(e.Message);
        }

        Console.WriteLine($"Current balance: {account.Balance}");

        Console.WriteLine("\nTransactions:");
        foreach (var transaction in account.GetTransactions())
        {
            Console.WriteLine(transaction.ToString());
        }

        Console.WriteLine();

        Console.WriteLine(account.GetInfo());
    }

    private static void ShowError(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ResetColor();
    }
}
