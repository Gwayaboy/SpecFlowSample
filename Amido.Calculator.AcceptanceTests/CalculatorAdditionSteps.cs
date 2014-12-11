using Amido.Calculator.Domain;
using TechTalk.SpecFlow;

namespace Amido.Calculator.AcceptanceTests
{
    [Binding]
    public class CalculatorAdditionSteps : Steps
    {
        [When(@"I add (.*) and (.*) together")]
        public void WhenIAddAndTogether(int p0, int p1)
        {
            When(string.Format("I choose {0}",OperationType.Addition));
            When(string.Format("I enter {0} into the calculator", p0));
            When(string.Format("I enter {0} into the calculator", p1));
        }
    }
}