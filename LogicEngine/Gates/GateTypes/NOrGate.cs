using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicEngine.Gates.GateTypes
{
    internal class NOrGate : ILogicGate
    {
        internal NotGate NotGate { get; }

        internal NOrGate(IEnumerable<ILogicGate> inputs)
        {
            var orGate = new OrGate(inputs);
            NotGate = new NotGate(orGate);
        }

        public bool Evaluate(Dictionary<string, bool> inputs)
        {
            return NotGate.Evaluate(inputs);
        }
    }
}
