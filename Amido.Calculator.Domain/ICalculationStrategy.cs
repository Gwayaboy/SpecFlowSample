using System.Collections.Generic;

namespace Amido.Calculator.Domain
{
    public interface ICalculationStrategy
    {
        int Calculate(IEnumerable<int> values);
    }
}