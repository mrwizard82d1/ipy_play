using IronPython.Hosting;
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
