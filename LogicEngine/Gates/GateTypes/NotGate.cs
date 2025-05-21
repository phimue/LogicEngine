using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicEngine.Gates.GateTypes
{
    public class NotGate : ILogicGate
    {
        public ILogicGate Input { get; }

        public NotGate(ILogicGate input)
        {
            Input = input;
        }

        public bool Evaluate(Dictionary<string, bool> inputs)
        {
            return !Input.Evaluate(inputs);
        }
    }
}
