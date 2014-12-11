using Amido.Calculator.Domain;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Amido.Common.AcceptanceTests
{
    [Binding]
    public class CommonCalculatorSteps
    {
        private readonly MyCalculator _calculator;
        private readonly InputData _inputData;

        public CommonCalculatorSteps(InputData inputData, MyCalculator calculator)
        {
            _inputData = inputData;
            _calculator = calculator;
        }

        [Given(@"I have cleared any previous result")]
        public void GivenIHaveClearedAnyPreviousResult()
        {
            _inputData.Values.Clear();
        }

        [When(@"I enter (.*) into the calculator")]
        public void WhenIEnterIntoTheCalculator(int value)
        {
            _inputData.Values.Add(value);
        }

        [When(@"I choose (.*)")]
        public void WhenIChooseAddition(OperationType operationType)
        {
            _inputData.Operation = operationType;
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int expectedResult)
        {
            Assert.That(_calculator.Calculate(_inputData.Values, _inputData.Operation), Is.EqualTo(expectedResult));
        }
    }
}