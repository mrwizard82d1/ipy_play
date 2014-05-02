namespace Atm
{
    public class Account
    {
        public string AccountNumber { get; private set; }
        public decimal Balance { get; private set; }
        public decimal MinimumBalance { get; set; }

        public Account(string number, decimal openingBalance = 0)
        {
            AccountNumber = number;
            Balance = openingBalance;
            MinimumBalance = 0;
        }

        public void Debit(decimal amount)
        {
            Balance -= amount;
        }
    }
}
