namespace exer;

public class Transactions
{
      public decimal Amount { get; }
      public DateTime Date { get; }
      public string Notes { get; }

      public Transactions(decimal amount, DateTime date, string notes)
      {
            Amount = amount;
            Date = date;
            Notes = notes;
      }
}