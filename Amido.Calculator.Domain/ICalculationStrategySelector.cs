namespace Amido.Calculator.Domain
{
    public interface ICalculationStrategySelector
    {
        ICalculationStrategy FindFor(OperationType operationType);

        ICalculationStrategySelector Register<TCalculationStrategy>(OperationType operationType)
            where TCalculationStrategy : class, ICalculationStrategy, new();
    }
}