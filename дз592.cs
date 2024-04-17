using System;

class Transaction
{
    public string ClientName { get; set; }
    public string ClientId { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string AccountId { get; set; }
    public decimal Balance { get; set; }
    public string OwnerName { get; set; }
    public decimal TransactionAmount { get; set; }
    public DateTime TransactionTime { get; set; }

    public Transaction(string clientName, string clientId, DateTime dateOfBirth, string accountId, decimal balance, string ownerName, decimal transactionAmount, DateTime transactionTime)
    {
        ClientName = clientName;
        ClientId = clientId;
        DateOfBirth = dateOfBirth;
        AccountId = accountId;
        Balance = balance;
        OwnerName = ownerName;
        TransactionAmount = transactionAmount;
        TransactionTime = transactionTime;
    }

    public override string ToString()
    {
        return $"Client: {ClientName}, Client ID: {ClientId}, Date of Birth: {DateOfBirth}, Account ID: {AccountId}, Balance: {Balance}, Owner: {OwnerName}, Transaction Amount: {TransactionAmount}, Transaction Time: {TransactionTime}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите ФИО клиента: ");
        string clientName = Console.ReadLine();
        Console.Write("Введите ID клиента: ");
        string clientId = Console.ReadLine();
        Console.Write("Введите дату рождения клиента: ");
        DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());

        Console.Write("Введите ID счета: ");
        string accountId = Console.ReadLine();
        Console.Write("Введите баланс счета: ");
        decimal balance = decimal.Parse(Console.ReadLine());
        Console.Write("Введите имя владельца счета: ");
        string ownerName = Console.ReadLine();

        Console.Write("Введите сумму транзакции: ");
        decimal transactionAmount = decimal.Parse(Console.ReadLine());
        Console.Write("Введите время транзакции: ");
        DateTime transactionTime = DateTime.Parse(Console.ReadLine());

        Transaction transaction = new Transaction(clientName, clientId, dateOfBirth, accountId, balance, ownerName, transactionAmount, transactionTime);

        if (transactionAmount > balance)
        {
            Console.WriteLine("Недостаточный баланс на счете.");
        }
        else
        {
            balance -= transactionAmount;

            transaction.Balance = balance;

            Console.WriteLine($"Транзакция успешно выполнена.");
            Console.WriteLine(transaction);
        }
    }
}
