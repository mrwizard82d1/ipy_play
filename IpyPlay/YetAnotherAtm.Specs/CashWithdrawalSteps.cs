using System.Collections.Generic;
using System.Globalization;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

using Atm;

using TechTalk.SpecFlow;
using NUnit.Framework;

namespace YetAnotherAtm.Specs
{
    [Binding]
    public class CashWithdrawalSteps
    {
        private Account _account;
        private readonly string _accountNumber;

        private readonly dynamic _steps;

        public CashWithdrawalSteps()
        {
            var ipyRuntime = Python.CreateRuntime();
            ipyRuntime.LoadAssembly(typeof(Account).Assembly);

            _steps = ipyRuntime.UseFile("cash_withdrawal_steps.py");

            _accountNumber = "125009";
        }

        [Given(@"I have \$(.*) in my account")]
        public void GivenIHaveInMyAccount(decimal openingBalance)
        {
            _account = _steps.create_account(_accountNumber,
                                             openingBalance);
            Assert.AreEqual(_accountNumber, _account.AccountNumber);
            Assert.AreEqual(openingBalance, _account.Balance);
        }

        [When(@"I request \$(.*)")]
        public void WhenIRequest(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I see \$(.*) dispensed")]
        public void ThenISeeDispensed(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
