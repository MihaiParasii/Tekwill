namespace OOP_HW1;

public class BankAccount(Person person, MoneyType moneyType, int accountNumber, ushort pinNumber)
{
    public MoneyType MoneyType { get; } = moneyType;
    public int Balance { get; private set; } = 0;
    private readonly DateOnly _creationDate = new(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
    private readonly int _accountNumber = accountNumber;
    private readonly ushort _pinNumber = pinNumber;
    private readonly Person _person = person;
    private readonly List<Transaction> _transactionsHistory = [];

    public void Deposit(int amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Invalid deposit amount. Amount must be positive.");
        }

        Balance += amount;
        _transactionsHistory.Add(new Transaction("Deposit", amount));
    }

    public void Withdraw(int amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Invalid withdrawal amount. Amount must be positive.");
        }

        if (Balance < amount)
        {
            throw new ArgumentException("Invalid withdrawal amount. Amount must be smaller than balance.");
        }

        Balance -= amount;
        _transactionsHistory.Add(new Transaction("Withdrawal", amount));
    }

    public IEnumerable<Transaction> GetTransactions() => _transactionsHistory;

    public string GetInfo()
    {
        return $"Bank Account Info:\n" +
               $"Account Number: {_accountNumber}\n" +
               $"Pin Number: {_pinNumber}\n" +
               $"Creation Date: {_creationDate}\n" +
               $"Money Type: {MoneyType}\n" +
               $"Balance: {Balance}\n" +
               $"Person: {_person.ToString()}" +
               $"Transactions count: {_transactionsHistory.Count}\n";
    }
}
