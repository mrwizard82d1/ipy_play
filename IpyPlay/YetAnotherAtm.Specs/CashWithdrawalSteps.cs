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
        private AccountNumber _accountNumber;
        private readonly string _accountNumberText;

        private readonly dynamic _steps;

        public CashWithdrawalSteps()
        {
            ScriptRuntime ipyRuntime = Python.CreateRuntime();
            _steps = ipyRuntime.UseFile("cash_withdrawal_steps.py");

            _accountNumberText = "125009";
        }

        [Given(@"I have deposited \$(.*) in my account")]
        public void GivenIHaveDepositedInMyAccount(int depositAmount)
        {
            var createResult = _steps.create_account(_accountNumberText);
            var results= new List<object>();
            foreach (var result in createResult)
            {
                results.Add(result);
            }
            Assert.AreEqual(true, results[0]);
            _accountNumber = (AccountNumber) results[1];
            var depositTransaction =
                _steps.create_deposit(_accountNumber,
                                      depositAmount.ToString(
                                          CultureInfo.InvariantCulture));
            _steps.execute_transaction(depositTransaction);
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
