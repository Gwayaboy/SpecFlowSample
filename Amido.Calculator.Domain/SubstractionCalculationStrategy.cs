using System.Collections.Generic;
using System.Linq;

namespace Amido.Calculator.Domain
{
    public class SubstractionCalculationStrategy : ICalculationStrategy
    {
        public int Calculate(IEnumerable<int> values)
        {
            var array = values as int[] ?? values.ToArray();
            return array.Skip(1).Aggregate(array.First(), (current, value) => current - value);
        }
    }
}