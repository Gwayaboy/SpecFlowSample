using Amido.Calculator.Domain;
using BoDi;
using TechTalk.SpecFlow;

namespace Amido.Common.AcceptanceTests
{
    [Binding]
    public class CalculatorConfigurator
    {
        private readonly IObjectContainer _objectContainer;

        public CalculatorConfigurator(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        [BeforeScenario]
        public void InitializeCalculator()
        {
            _objectContainer.RegisterInstanceAs(
                new MyCalculator(
                    new CalculationStrategySelector()
                        .Register<AdditionCalculationStrategy>(OperationType.Addition)
                        .Register<SubstractionCalculationStrategy>(OperationType.Substraction)));
        }
    }

}