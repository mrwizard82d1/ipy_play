using IronPython.Hosting;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using TechTalk.SpecFlow;

namespace YetAnotherAtm.Specs
{
    [Binding]
    public class CashWithdrawalSteps
    {
        private readonly dynamic _steps;

        public CashWithdrawalSteps()
        {
            var ipyRuntime = Python.CreateRuntime();
            _steps = ipyRuntime.UseFile("cash_withdrawal_steps.py");
        }

        [Given(@"I have \$(.*) in my account")]
        public void GivenIHaveInMyAccount(decimal openingBalance)
        {
            _steps.create_account(openingBalance);
        }

        [When(@"I request \$(.*)")]
        public void WhenIRequest(decimal amount)
        {
            _steps.request_cash_withdrawal(amount);
        }

        [Then(@"I see \$(.*) dispensed")]
        public void ThenISeeDispensed(decimal dispensed)
        {
            Assert.AreEqual(dispensed, _steps.cash_dispensed);
        }
    }
}
