using System.Collections.Generic;

namespace Amido.Calculator.Domain
{
    public class MyCalculator
    {
        private readonly ICalculationStrategySelector _calculationStrategySelector;

        public MyCalculator(ICalculationStrategySelector calculationStrategySelectorSelector)
        {
            _calculationStrategySelector = calculationStrategySelectorSelector;
        }

        public int Calculate(IEnumerable<int> values, OperationType operation)
        {
            return _calculationStrategySelector.FindFor(operation).Calculate(values);
        }
    }
}