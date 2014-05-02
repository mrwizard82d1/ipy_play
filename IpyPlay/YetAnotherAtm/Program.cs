using System;
using Atm;

namespace YetAnotherAtm
{
    class Program
    {
        static void Main()
        {
            var atm = Atm();
            var account = GetAccount();
            if (account != null)
            {
                ExecuteTransactions(atm, account);              
            }
        }

        private static void ExecuteTransactions(Atm.Atm atm,
                                                Account account)
        {
            Console.Write("Transaction? ");
            var transactionLine = Console.ReadLine();
            while (transactionLine != null)
            {
                var transactionParts = transactionLine.Split();
                if (transactionParts[0].ToLower().Equals("withdraw"))
                {
                    decimal amount;
                    if (Decimal.TryParse(transactionParts[1],
                                         out amount))
                    {
                        var cashDispensed = atm.WithdrawCash(account,
                                                               amount);
                        Console.WriteLine("Successfully withdrew {0:C}",
                                          cashDispensed);
                    }
                }
                Console.Write("Transaction? ");
                transactionLine = Console.ReadLine();
            }
        }

        private static Account GetAccount()
        {
            Console.Write("Account? ");
            string accountNumberText = Console.ReadLine();
            return new Account(accountNumberText);
        }
    }
}
