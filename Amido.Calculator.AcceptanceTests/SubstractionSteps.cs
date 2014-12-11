using Amido.Calculator.Domain;
using Amido.Common.AcceptanceTests;
using TechTalk.SpecFlow;

namespace Amido.Calculator.AcceptanceTests
{
    [Binding]
    public class SubstractionSteps
    {
        private readonly InputData _inputData;

        public SubstractionSteps(InputData inputData)
        {
            _inputData = inputData;
        }

        [When(@"I take away (.*) from (.*)")]
        public void WhenITakewayFrom(int takeAway, int from)
        {
            _inputData.Operation = OperationType.Substraction;
            _inputData.Values.Add(from);
            _inputData.Values.Add(takeAway);
        }
    }
}