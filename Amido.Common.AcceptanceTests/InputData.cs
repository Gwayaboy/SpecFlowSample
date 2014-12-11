using System.Collections.Generic;
using Amido.Calculator.Domain;

namespace Amido.Common.AcceptanceTests
{
    public class InputData
    {
        public List<int> Values { get; private set; }

        public InputData()
        {
            Values = new List<int>();
        }

        public OperationType Operation { get; set; }
    }
}