using System;

namespace Atm
{
    public class AccountNumber
    {
        private readonly string _number;

        public AccountNumber(string number)
        {
            _number = number;
        }

        public static bool TryParse(string accountNumberText,
                                    out AccountNumber accountNumber)
        {
            int unused;
            accountNumber = null;
            var isParsed = Int32.TryParse(accountNumberText, out unused);
            if (isParsed)
            {
                accountNumber = new AccountNumber(accountNumberText);
            }
            return isParsed;
        }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>
        /// A string that represents the current object.
        /// </returns>
        public override string ToString()
        {
            return String.Format("AccountNumber({0})", _number);
        }
    }
}
