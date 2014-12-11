using System.Collections.Generic;

namespace Amido.Calculator.Domain
{
    public class NullCalculationStrategy : ICalculationStrategy
    {
        public static ICalculationStrategy Instance
        {
            get { return new NullCalculationStrategy(); }
        }

        public int Calculate(IEnumerable<int> values)
        {
            return 0;
        }
    }
}