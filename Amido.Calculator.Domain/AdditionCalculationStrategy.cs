using System.Collections.Generic;
using System.Linq;

namespace Amido.Calculator.Domain
{
    public class AdditionCalculationStrategy : ICalculationStrategy
    {
        public int Calculate(IEnumerable<int> values)
        {
            return values.Sum();
        }
    }
}