using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicEngine.Gates.GateTypes
{
    internal class NotGate : ILogicGate
    {
        internal ILogicGate Input { get; }
        internal NotGate(ILogicGate input)
        {
            Input = input;
        }

        public bool Evaluate(Dictionary<string, bool> inputs)
        {
            return !Input.Evaluate(inputs);
        }
    }
}
