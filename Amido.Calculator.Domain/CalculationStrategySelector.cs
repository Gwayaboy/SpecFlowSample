using System.Collections.Generic;

namespace Amido.Calculator.Domain
{
    public class CalculationStrategySelector : ICalculationStrategySelector
    {
        private readonly IDictionary<OperationType, ICalculationStrategy> _calculationStrategies =
            new Dictionary<OperationType, ICalculationStrategy>();

        public ICalculationStrategy FindFor(OperationType operationType)
        {
            return _calculationStrategies.ContainsKey(operationType)
                ? _calculationStrategies[operationType]
                : NullCalculationStrategy.Instance;
        }

        public ICalculationStrategySelector Register<TCalculationStrategy>(OperationType operationType)
            where TCalculationStrategy : class, ICalculationStrategy, new()
        {
            _calculationStrategies[operationType] = new TCalculationStrategy();
            return this;
        }
    }
}