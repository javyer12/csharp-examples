
namespace exer;
public class BankAccount
{
      private static int accountNumberSeed = 1234567890;
      public string Number { get; set; }
      public string Owner { get; set; }
      public decimal Balance
      {
            get
            {
                  decimal balance = 0;
                  foreach (var item in allTransactions)
                  {
                        balance += item.Amount;
                  }
                  return balance;
            }
      }

      //   private me impide usarlo desde afuera de la clase.
      // static me permite que todas las personas que creen  una cuenta, tendran ese saldo bono inicial
      private decimal initialAmount = 500;

      // this is the constructor
      public BankAccount(string name, decimal initialBalance)
      {
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
            this.Owner = name;
            AccountCreated(initialBalance + initialAmount);
            Console.WriteLine($"Initial Deposit: {initialBalance + initialAmount}");
            MakeDeposit(initialBalance + initialAmount, DateTime.Now, "Initial balance");
      }
      //   list to save all bank acount transactions
      public void AccountCreated(decimal amount)
      {
            Console.WriteLine($"Account {this.Number} was created for {this.Owner} with {amount},  due to you got an initial balance of $500");
      }
      private List<Transactions> allTransactions = new List<Transactions>();

      public void MakeDeposit(decimal amount, DateTime date, string notes)
      {
            if (amount <= 0)
            {
                  throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            var deposit = new Transactions(amount, date, notes);
            allTransactions.Add(deposit);
            Console.WriteLine($"{this.Owner} made a deposit of {amount}");
      }
      public void MakeWithdrawal(decimal amount, DateTime date, string note)
      {
            if (amount <= 0)
            {
                  // excepciones, manejos de errores
                  throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            if (Balance - amount < 0)
            {
                  // excepciones, manejos de errores
                  throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }

            var withdrawal = new Transactions(-amount, date, note);
            allTransactions.Add(withdrawal);
            Console.WriteLine($"{this.Owner} made a withdrawal  of {amount}");
      }
      public string GetAccuntHistory()
      {
            var report = new System.Text.StringBuilder();
            decimal balance = 0;
            report.AppendLine("Date\t\tAmount\tBalance\tNote");
            foreach (var item in allTransactions)
            {
                  balance += item.Amount;
                  report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Notes}");
            }
            return report.ToString();
      }
}