namespace OOP_HW1;

public class Transaction(string transaction, int amount = 0)
{
    private string TransactionType { get; set; } = transaction;
    private int Amount { get; set; } = amount;
    
    public override string ToString() => $"Transaction: {TransactionType}, Amount: {Amount}";
}
