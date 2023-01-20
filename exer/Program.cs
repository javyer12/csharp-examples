// con esta linea accedemos desde la raiz del proyecto
using exer;

var RafaLeo = new BankAccount("Rafa Leo", 1000);
RafaLeo.MakeWithdrawal(500, DateTime.Now, "RENT PAYMENT");
RafaLeo.MakeWithdrawal(300, DateTime.Now, "CAR PAYMENT");

RafaLeo.MakeDeposit(300, DateTime.Now, "Save for the chrismas night");
RafaLeo.MakeWithdrawal(300, DateTime.Now, " buy the christmas tree");

Console.WriteLine($"Your Balance is {RafaLeo.Balance}");
Console.WriteLine($"Your financial  report is: ");
Console.WriteLine(RafaLeo.GetAccuntHistory());

// var Leandro = new BankAccount("Leandro", 500);
// Console.WriteLine($"Account {Leandro.Number} was created for {Leandro.Owner} with {Leandro.Balance},  due to you got an initial balance of $500");
// try
// {
//       RafaLeo.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
// }
// catch (InvalidOperationException e)
// {
//       Console.WriteLine("Exception caught trying to overdraw");
//       Console.WriteLine(e.ToString());
// }

// BankAccount invalidAccount;
// try
// {
//       invalidAccount = new BankAccount("invalid", -55);
// }
// catch (ArgumentOutOfRangeException e)
// {
//       Console.WriteLine("Exception caught creating account with negative balance");
//       Console.WriteLine(e.ToString());
//       return;
// }